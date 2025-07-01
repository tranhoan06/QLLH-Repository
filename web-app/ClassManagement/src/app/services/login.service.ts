import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { delay } from 'rxjs/operators';
import * as fakeData from '../shared/data/fakeLogin.json';

export interface LoginResponse {
  data: any;
  status_code: number;
  status_messenger: string;
}

@Injectable({ providedIn: 'root' })
export class LoginService {
  private users = (fakeData as any).default || fakeData;

  login(username: string, password: string): Observable<LoginResponse> {
    const user = this.users.find((u: any) => u.username === username && u.password === password);
    if (user) {
      return of({
        data: user,
        status_code: 200,
        status_messenger: 'Đăng nhập thành công!'
      }).pipe(delay(500));
    } else {
      return of({
        data: null,
        status_code: 401,
        status_messenger: 'Tên đăng nhập hoặc mật khẩu không đúng!'
      }).pipe(delay(500));
    }
  }

  register(newUser: any): Observable<LoginResponse> {
    const exists = this.users.some((u: any) => u.username === newUser.username || u.email === newUser.email);
    if (exists) {
      return of({
        data: null,
        status_code: 409,
        status_messenger: 'Tài khoản hoặc email đã tồn tại!'
      }).pipe(delay(500));
    }
    // Giả lập thêm user mới vào mảng (chỉ trên RAM, không ghi file)
    this.users.push({ ...newUser, token: 'fake_token_' + Date.now() });
    return of({
      data: newUser,
      status_code: 201,
      status_messenger: 'Đăng ký thành công!'
    }).pipe(delay(500));
  }
}

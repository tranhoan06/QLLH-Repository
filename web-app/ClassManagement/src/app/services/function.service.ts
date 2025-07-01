import { Injectable } from '@angular/core';
import * as fakeFunction from '../shared/data/fakeFunction.json';

@Injectable({ providedIn: 'root' })
export class FunctionService {
  private functions = fakeFunction;

  getFunctionsByUserId(userId: number) {
    const found = this.functions.find((f: any) => f.userId === userId);
    return found ? found.functions : [];
  }     
}

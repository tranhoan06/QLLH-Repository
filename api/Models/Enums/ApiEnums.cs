﻿using System;
using System.Collections.Generic;
using System.Text;

namespace api.Enums
{
    public class ApiEnums
    {
        public enum EntityStatus
        {
            NORMAL = 1,
            OK = 2,
            NOT_OK = 3,
            TEMP = 10,
            LOCK = 98,
            DELETED = 99,
        }

        public enum CacheDataTypes
        {
            ByteArray = 0, // Can convert to byte array
            Json = 1
        }

        public enum ShowLogLevel
        {
            Default = 0,
            Production = 1,
            Stacktrace = 2
        }

        public enum Action
        {
            VIEW = 0,
            CREATE = 1,
            UPDATE = 2,
            DELETED = 3,
            IMPORT = 4,
            EXPORT = 5,
            PRINT = 6,
            EDIT_ANOTHER_USER = 7,
            MENU = 8,
            LOG_IN = 9,
            LOG_OUT = 10
        }

        public enum TypeFunction    // Phân quyền chức năng với người dùng và nhóm quyền
        {
            FUNCTION_USER = 1, // Người dùng - Chức năng
            FUNCTION_ROLE = 2,    // Nhóm quyền - Chức năng
            FUNCTION_SERVICE = 3,    // Gói dịch vụ - Chức năng
            FUNCTION_CUSTOMER_IN = 4,    // Khách hàng nội bộ - Chức năng
        }

        public enum TypeUser
        {
            ADMINISTRATOR = 1, //quản trị hệ thống
            MANAGEMENT = 2, //ban quản lý
            ADMIN_CUSTOMER_IN = 3, //Khách hàng nội bộ
            TEACHER = 4, //Giáo viên
            STUDENT = 5, //Học viên
        }

        public enum TypeAction    // loại hành động
        {
            ACTION = 1, // Hành động
            NOTIFICATION = 2, // Thông báo
            WARNING = 3         //Cảnh báo
        }

        public enum FileType
        {
            IMAGE = 1,
            FILE = 2
        }
        public enum TypeAttactment //Loại file đính kèm
        {
            DOCUMENT = 1,         //File đính kèm Tài liệu
        }

        public enum TypeFCM
        {
            NEW_MESSAGE = 1, //tin nhắn
            NEW_EMAIL = 2, //email
            NEW_REPLY = 3, //trả lời
            NEW_COMMENT = 4, //bình luận
        }

        public enum TypePaymentStatus    // trang thái thanh toán
        {
            INIT = 1, // chưa thanh toán
            FULL = 2,    // đã thanh toán hết
            NOT_ENOUGH = 3,    // chưa thanh toán hết
            NOT_PAYMENT = 4     // không thanh toán
        }

        public enum TypePaymentMethod    // phương thức thanh toán
        {
            DIRECT = 1, // Bằng tiền mặt
            ONLINE = 2,    // Online
            OTHER = 3,    // Khác
        }
        public enum TypeFile    // loại file
        {
            DOCUMENTS = 1, // file văn bản
            VIDEO = 2,    // file video
            AUDIO = 3,    // file âm thanh
            ELECTRONIC_BOOKS = 4,    // file sách điện tử
            IMAGES = 5,    // file hình ảnh
            ARCHIVES = 6,    // file nén
            OTHER = 7           //Loại khác
        }

        public enum TypeRegister    // hình thức đăng ký
        {
            EMAIL = 1, // đăng ký bằng email
            PHONE_NUMBER = 2,    // đăng ký bằng sdt
            FACEBOOK = 3, // đăng ký bằng face
            GOOGLE = 4, // đăng ký bằng google
        }

        public enum TypeDate    // loại ngày lọc
        {
            DATE_CREATED = 1, // tạo
            DATE_ACTIVED = 2, // hoạt động
            DATE_UPDATED = 3, //cập nhật
        }

    }
}

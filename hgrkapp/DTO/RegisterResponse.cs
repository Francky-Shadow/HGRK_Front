﻿namespace hgrkapp.DTO
{
    public class RegisterResponse
    {
        public Guid Id { get; set; }
        public string? Username { get; set; }
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }
    }
}

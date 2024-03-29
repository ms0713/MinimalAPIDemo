﻿using DataAccessLib.Models;

namespace DataAccessLib.Data;
public interface IUserData
{
  Task CreateUser(UserModel user);
  Task DeleteUser(int id);
  Task<UserModel?> GetUserById(int Id);
  Task<IEnumerable<UserModel>> GetUsers();
  Task UpdateUser(UserModel user);
}

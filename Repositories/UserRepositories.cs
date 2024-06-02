﻿using BbCenter.Dto.User;
using BbCenter.Models;
using BbCenter.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace BbCenter.Repositories
{
    public class UserRepositories : IUserRepositories
    {
        private readonly ApplicationDbContext _context;

        public UserRepositories(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateUser(User user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error creating user");
            }
        }

        public void DeleteUser(User user)
        {
            try
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error deleting user");
            }
        }

        public List<User> GetAllUser()
        {
            try
            {
                return _context.Users
                    .Include(u => u.Role)
                    .Include(u => u.Center)
                    .Include(u => u.Subject)
                    .AsNoTracking()
                    .Where(u => u.Email != "admin@gmail.com")
                    .ToList();
            }
            catch (Exception)
            {
                throw new Exception("Error getting all user");
            }
        }

        public List<User> GetAllUserByRoleIdAndBranchId(QueryDto queryDto)
        {
            try
            {
                var query = _context.Users
                    .Include(u => u.Role)
                    .Include(u => u.Center)
                    .Include(u => u.Subject)
                    .AsQueryable();

                List<User> users = query.ToList();

                if (queryDto.RoleId.HasValue)
                {
                    query = query.Where(u => u.RoleId == queryDto.RoleId);
                }

                if (queryDto.CenterId.HasValue)
                {
                    query = query.Where(u => u.CenterId == queryDto.CenterId);
                }
                if (queryDto.SubjectId.HasValue)
                {
                    query = query.Where(u => u.SubjectId == queryDto.SubjectId);
                }
                if (queryDto.Email != null)
                {
                    query = query.Where(u => u.Email == queryDto.Email);
                }

                users = query.ToList();

                return users;
            }
            catch (Exception)
            {
                throw new Exception("Error getting all user by role and faculty");
            }
        }

        public User GetUserByEmail(string email)
        {
            try
            {
                User user = _context.Users
                    .Include(u => u.Center)
                    .Include(u => u.Role)
                    .FirstOrDefault(u => u.Email == email);
                return user;
            }
            catch (Exception)
            {
                throw new Exception("Error getting user");
            }
        }

        public User GetUserById(Guid id)
        {
            try
            {
                return _context.Users
                    .Include(u => u.Center)
                    .Include(u => u.Role)
                    .AsNoTracking()
                    .FirstOrDefault(u => u.UserId == id);
            }
            catch (Exception)
            {
                throw new Exception("Error getting user");
            }
        }

        public void UpdateUser(User user)
        {
            try
            {
                _context.Entry<User>(user).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error updating user");
            }
        }
    }
}

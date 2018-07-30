using AspNet.Identity.MongoDB;
using MongoDB.Driver;
using System;

namespace IdentityMongo.Models
{
    public class ApplicationDbContext : IDisposable
    {
        public static ApplicationDbContext Create()
        {
            //使用 mongo連線資訊建立 mongodb client
            var client = new MongoClient("mongodb://127.0.0.1:27017");
            //指定儲存的 db
            var database = client.GetDatabase("Identity");
            //指定 user 存放的 collection
            var users = database.GetCollection<ApplicationUser>("users");
            //指定 role 存放的 collection
            var roles = database.GetCollection<IdentityRole>("roles");
            // 回傳 private 建構子內容
            return new ApplicationDbContext(users, roles);
        }
        private ApplicationDbContext(IMongoCollection<ApplicationUser> users, IMongoCollection<IdentityRole> roles)
        {
            Users = users;
            Roles = roles;
        }

        public IMongoCollection<IdentityRole> Roles { get; set; }

        public IMongoCollection<ApplicationUser> Users { get; set; }
        public void Dispose()
        {
        }
    }
}
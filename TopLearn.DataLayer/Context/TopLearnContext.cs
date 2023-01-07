using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TopLearn.DataLayer.Entities.Course;
using TopLearn.DataLayer.Entities.Order;
using TopLearn.DataLayer.Entities.Permission;
using TopLearn.DataLayer.Entities.User;
using TopLearn.DataLayer.Entities.Wallet;

namespace TopLearn.DataLayer.Context
{
    public class TopLearnContext : DbContext
    {
        public TopLearnContext(DbContextOptions<TopLearnContext> options) : base(options)
        {

        }
        #region Dbsets
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<WalletType> WalletTypes { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Permission> permission { get; set; }
        public DbSet<RolePermission> RolePermission { get; set; }
        public DbSet<CourseGroup> CourseGroup { get; set; }
        public DbSet<CourseLevel> CourseLevels { get; set; }
        public DbSet<CourseStatus> CourseStatuses { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseEpisode> CourseEpisodes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<UserCourse>  UserCourses { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<UserDiscountCode> UserDiscountCodes { get; set; }
        public DbSet<CourseComment> CourseComments { get; set; }
         #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
               .SelectMany(t => t.GetForeignKeys())
               .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;



            modelBuilder.Entity<Entities.Course.CourseGroup>()
                .HasQueryFilter(r => !r.IsDelete);

            modelBuilder.Entity<Course>()
                .HasOne<CourseGroup>(c => c.CourseGroup)
                .WithMany(cg => cg.Courses)
                .HasForeignKey(fk => fk.GroupId);

            modelBuilder.Entity<Course>()
                .HasOne<CourseGroup>(c => c.Group)
                .WithMany(cg => cg.SubGroup)
                .HasForeignKey(fk => fk.SubGroup);
            
            base.OnModelCreating(modelBuilder);
        }
         
    }
}


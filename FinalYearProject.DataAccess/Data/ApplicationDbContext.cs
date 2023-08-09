using Bobmlm.Models;
using FinalYearProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace FinalYearProject.Data
{
	public class ApplicationDbContext : IdentityDbContext<AppUsers>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
		
		public DbSet<LevelMaster> LevelMaster { get; set; }
		
		public DbSet<Transactions> Transactions { get; set; }

		public virtual DbSet<MemberLevelResult> MemberLevels { get; set; }
		public virtual DbSet<LevelCount> LevelCount { get; set; }
		public DbSet<PayoutRequest> PayoutRequest { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<ShoppingCart> ShoppingCarts { get; set; }
		public DbSet<OrderHeader> OrderHeaders { get; set; }
		public DbSet<OrderDetail> OrderDetails { get; set; }
		public DbSet<ProductImage> ProductImages { get; set; }
		public DbSet<OfferBanner> OfferBanner { get; set; }	
		public DbSet<BannerSlide> BannerSlides { get; set; }
		public DbSet<PointsTransaction> PointsTransactions { get; set; }
		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			// change default identity table 
			builder.Entity<AppUsers>().ToTable("Members");
			builder.Entity<IdentityRole>().ToTable("Roles");
			builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");
			builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
			builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
			builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
			builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");

		    builder.Entity<OrderDetail>()
			   .HasOne(od => od.OrderHeader)
			   .WithMany()
			   .HasForeignKey(od => od.OrderHeaderId)
			   .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<OrderDetail>()
                .HasOne(od => od.Product)
                .WithMany()
                .HasForeignKey(od => od.ProductId)
                .OnDelete(DeleteBehavior.Restrict);
			builder.Entity<ShoppingCart>()
                 .HasOne(od => od.Product)
               .WithMany()
               .HasForeignKey(od => od.ProductId)
               .OnDelete(DeleteBehavior.Restrict);

			#region Register admin and member users
			const string adminRoleName = "Admin";

			// Create admin role
			var adminRoleId = Guid.NewGuid().ToString();
			builder.Entity<IdentityRole>().HasData(new IdentityRole
			{
				Id = adminRoleId,
				Name = adminRoleName,
				NormalizedName = adminRoleName.ToUpperInvariant()
			});


			// Create admin user
			var adminUserId = Guid.NewGuid().ToString();
			var hasher = new PasswordHasher<AppUsers>();
			builder.Entity<AppUsers>().HasData(new AppUsers
			{
				Id = adminUserId,
				UserName = "Admin",
				NormalizedUserName = "ADMIN",
				Email = "admin@vendorloom.com",
				FullName = "Super Admin",
				Regdate = DateTime.Now,
				RefCode = "n/a",
				EmailConfirmed = true,
				PhoneNumberConfirmed = true,
				SecurityStamp = Guid.NewGuid().ToString(),
				ConcurrencyStamp = Guid.NewGuid().ToString(),
				NormalizedEmail = "ADMIN@VENDORLOOM.COM",
				PasswordHash = hasher.HashPassword(null, "12345")
			});

			// Assign roles to users
			builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
			{
				RoleId = adminRoleId,
				UserId = adminUserId
			});


			#endregion
		}
	}
}
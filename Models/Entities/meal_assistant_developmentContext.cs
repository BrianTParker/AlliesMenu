using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace meal_assistant_dotnet_mvc.Models.Entities
{
    public partial class meal_assistant_developmentContext : DbContext
    {
        public meal_assistant_developmentContext()
        {
        }

        public meal_assistant_developmentContext(DbContextOptions<meal_assistant_developmentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ComponentTags> ComponentTags { get; set; }
        public virtual DbSet<Components> Components { get; set; }
        public virtual DbSet<Feedbacks> Feedbacks { get; set; }
        public virtual DbSet<MainDishes> MainDishes { get; set; }
        public virtual DbSet<MealTimes> MealTimes { get; set; }
        public virtual DbSet<Meals> Meals { get; set; }
        public virtual DbSet<MealsComponents> MealsComponents { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }
        public virtual DbSet<Users> Users { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity<ComponentTags>(entity =>
            {
                entity.ToTable("component_tags");

                entity.HasIndex(e => e.ComponentId)
                    .HasName("index_component_tags_on_component_id");

                entity.HasIndex(e => e.TagId)
                    .HasName("index_component_tags_on_tag_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ComponentId).HasColumnName("component_id");

                entity.Property(e => e.TagId).HasColumnName("tag_id");

                entity.HasOne(d => d.Component)
                    .WithMany(p => p.ComponentTags)
                    .HasForeignKey(d => d.ComponentId)
                    .HasConstraintName("fk_rails_89f23cfd96");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.ComponentTags)
                    .HasForeignKey(d => d.TagId)
                    .HasConstraintName("fk_rails_e168d83886");
            });

            modelBuilder.Entity<Components>(entity =>
            {
                entity.ToTable("components");

                entity.HasIndex(e => e.UserId)
                    .HasName("index_components_on_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comments).HasColumnName("comments");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.Rating)
                    .HasColumnName("rating")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasColumnType("character varying");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("character varying");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Components)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_rails_624f40a895");
            });

            modelBuilder.Entity<Feedbacks>(entity =>
            {
                entity.ToTable("feedbacks");

                entity.HasIndex(e => e.UserId)
                    .HasName("index_feedbacks_on_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_rails_c57bb6cf28");
            });

            modelBuilder.Entity<MainDishes>(entity =>
            {
                entity.ToTable("main_dishes");

                entity.HasIndex(e => e.MealId)
                    .HasName("index_main_dishes_on_meal_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comments).HasColumnName("comments");

                entity.Property(e => e.MealId).HasColumnName("meal_id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Meal)
                    .WithMany(p => p.MainDishes)
                    .HasForeignKey(d => d.MealId)
                    .HasConstraintName("fk_rails_dd5aa3f07c");
            });

            modelBuilder.Entity<MealTimes>(entity =>
            {
                entity.ToTable("meal_times");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Meals>(entity =>
            {
                entity.ToTable("meals");

                entity.HasIndex(e => e.MealTimeId)
                    .HasName("index_meals_on_meal_time_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.MealTimeId).HasColumnName("meal_time_id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.MealTime)
                    .WithMany(p => p.Meals)
                    .HasForeignKey(d => d.MealTimeId)
                    .HasConstraintName("fk_rails_f94c6134ac");
            });

            modelBuilder.Entity<MealsComponents>(entity =>
            {
                entity.ToTable("meals_components");

                entity.HasIndex(e => e.ComponentId)
                    .HasName("index_meals_components_on_component_id");

                entity.HasIndex(e => e.MealId)
                    .HasName("index_meals_components_on_meal_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ComponentId).HasColumnName("component_id");

                entity.Property(e => e.MealId).HasColumnName("meal_id");
            });

            modelBuilder.Entity<Tags>(entity =>
            {
                entity.ToTable("tags");

                entity.HasIndex(e => e.UserId)
                    .HasName("index_tags_on_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.Email)
                    .HasName("index_users_on_email")
                    .IsUnique();

                entity.HasIndex(e => e.ResetPasswordToken)
                    .HasName("index_users_on_reset_password_token")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CurrentSignInAt).HasColumnName("current_sign_in_at");

                entity.Property(e => e.CurrentSignInIp).HasColumnName("current_sign_in_ip");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("character varying");

                entity.Property(e => e.EncryptedPassword)
                    .IsRequired()
                    .HasColumnName("encrypted_password")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.LastSignInAt).HasColumnName("last_sign_in_at");

                entity.Property(e => e.LastSignInIp).HasColumnName("last_sign_in_ip");

                entity.Property(e => e.Provider)
                    .HasColumnName("provider")
                    .HasColumnType("character varying");

                entity.Property(e => e.RememberCreatedAt).HasColumnName("remember_created_at");

                entity.Property(e => e.ResetPasswordSentAt).HasColumnName("reset_password_sent_at");

                entity.Property(e => e.ResetPasswordToken)
                    .HasColumnName("reset_password_token")
                    .HasColumnType("character varying");

                entity.Property(e => e.SignInCount).HasColumnName("sign_in_count");

                entity.Property(e => e.Token)
                    .HasColumnName("token")
                    .HasColumnType("character varying");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });
        }
    }
}

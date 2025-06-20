﻿namespace Optern.Infrastructure.Configurations
{
    public class CommentReactsConfiguration : IEntityTypeConfiguration<CommentReacts>
    {
        public void Configure(EntityTypeBuilder<CommentReacts> builder)
        {

            #region Attributes
            // Table Name

            builder.ToTable("CommentReacts");

            // Primary Key 


            builder.HasKey(cr => cr.Id);
            builder.Property(cr => cr.Id)
           .ValueGeneratedOnAdd();

            //Properties


            builder.Property(cr => cr.ReactType)
                   .HasConversion<string>()
                   .IsRequired();

            builder.Property(cr => cr.UserId)
                   .HasMaxLength(450)
                   .IsRequired();

            builder.Property(cr => cr.CommentId)
                   .IsRequired();

            // Indexes

            builder.HasIndex(cr => new { cr.CommentId, cr.UserId })
                   .IsUnique()
                   .HasDatabaseName("IX_CommentReact_CommentId_UserId"); 


            #endregion

            #region Relations

            builder.HasOne(cr => cr.User)
                   .WithMany(u => u.CommentReacts) 
                   .HasForeignKey(cr => cr.UserId) 
                   .OnDelete(DeleteBehavior.Cascade); 

            builder.HasOne(cr => cr.Comment)
                   .WithMany(c => c.CommentReacts) 
                   .HasForeignKey(cr => cr.CommentId) 
                   .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }

}

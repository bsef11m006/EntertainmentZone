﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ead_Project.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EntertainmentEntities1 : DbContext
    {
        public EntertainmentEntities1()
            : base("name=EntertainmentEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Action> Actions { get; set; }
        public DbSet<Cell_Phone> Cell_Phone { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Music> Musics { get; set; }
        public DbSet<Muzic> Muzics { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public DbSet<Technology> Technologies { get; set; }
        public DbSet<User> Users { get; set; }
    }
}

﻿using Microsoft.EntityFrameworkCore;
using NewsPublish.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPublish.Service
{
  public  class Db:DbContext
    {
        public Db() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            //以前的连接法
            //base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlServer("Data Source=127.0.0.1;Initial Catalog=NewsPublish; ID=sa;Password=cgw", b => b.UseRowNumberForPaging());
            optionsBuilder.UseSqlServer(@"Server=.;Data Source=127.0.0.1;uid=sa;pwd=cgw;DataBase=NewsPublish");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Banner> Banner {get;set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsClassify> NewsClassify { get; set; }
        public virtual DbSet<NewsComment> NewsComment { get; set; }
    }
}
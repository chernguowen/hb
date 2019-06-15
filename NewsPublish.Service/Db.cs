using Microsoft.EntityFrameworkCore;
using NewsPublish.Model.Entity;
using System.Xml.Linq;
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
            //用xml连接数据库
            XDocument doc = XDocument.Load("Config.xml");
            string dbcontent = doc.Element("Root").Element("Name").Value;
            optionsBuilder.UseSqlServer(@dbcontent);
            // optionsBuilder.UseSqlServer(@"Server=.;Data Source=127.0.0.1;uid=sa;pwd=cgw;DataBase=NewsPublish");
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

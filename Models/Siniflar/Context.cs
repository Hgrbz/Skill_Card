using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Skill_Profile.Models.Siniflar
{
    public class Context:DbContext
    {
       public Context() : base("Baglanti1") { }// Burada Baglanti1 isimli connectionstring'ine git demek. bu yazılmasaydı connectionstring adı context class'ının adıyla aynı olmak zorundaydı.
        public DbSet<Skills> Yetenekler { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace News.Models
{
    public class DocumentDataContext : DbContext
    {
        public DbSet<Document> Documents { get; set; }
        public DocumentDataContext()
            :base("DocumentDBConnection")
            {

            }
        
    }
}
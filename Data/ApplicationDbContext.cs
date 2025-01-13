using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using NoEntryZoneWeb.Models;

namespace NoEntryZoneWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Notice> Notices { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Ranking> Rankings { get; set; }
        public DbSet<CommunityPost> CommunityPosts { get; set; }
        public DbSet<Media> MediaItems { get; set; }
        public DbSet<SupportTicket> SupportTickets { get; set; }
    }
}

﻿using BlazorEcommerce.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEcommerce.Server.Data
{
  public class DataContext: DbContext
  {
    public DataContext(DbContextOptions<DataContext> options): base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Product>().HasData(
          new Product
          {
            Id = 1,
            Title = "Genji monogatari",
            Description = "Based on the classic novel by Murasaki Shikibu, written over 1000 years ago. Genji, the son of the emperor, has gained renown among the nobility of Kyoto for his charm and good looks, yet he cannot stop himself from pursuing the one object of desire he must never obtain: his father's young and beautiful bride. Following the tragic consequences of his obsession, Genji wanders from one affair to another, always seeking some sort of completion to his life. —Jean-Marc Rocher",
            ImageUrl = "https://img.yts.mx/assets/images/movies/genji_monogatari_1966/medium-cover.jpg",
            Price = 99.25m
          },
          new Product
          {
            Id = 2,
            Title = "Ted K",
            Description = "Ted K lives a life of almost complete seclusion in a simple wooden cabin in the mountains of Montana. But then this former university professor, who despises modern society and its faith in technology, becomes radicalized. What begins with local acts of sabotage, ends with deadly bomb attacks. To the outside world, Ted K becomes known as the Unabomber. Based on Ted Kaczynski's diaries and writings, Tony Stone's film is a kaleidoscopic true crime journey into the life of one of America's most complex and eccentric killers. It features a tour-de-force performance from Sharlto Copley who portrays the complexity of this unique outsider, raging at the forces of both the inescapable technological society that plagues him and his own inner demons",
            ImageUrl = "https://img.yts.mx/assets/images/movies/ted_k_2021/medium-cover.jpg",
            Price = 56.25m
          },
          new Product
          {
            Id = 3,
            Title = "Scream",
            Description = "Twenty-five years after the original series of murders in Woodsboro, a new Ghostface emerges, and Sidney Prescott must return to uncover the truth.",
            ImageUrl = "https://img.yts.mx/assets/images/movies/scream_2022/medium-cover.jpg",
            Price = 54.12m
          },
          new Product
          {
            Id = 4,
            Title = "Dancing with Maria",
            Description = "Maria Fux is a 90 years old Argentinian dancer. In her studio in Buenos Aires she is dancing, teaching and conserving the elegance and the energy of a young performer. She gives to people in her classes the possibility to develop their own way of expressing themselves. After a period of training with her, a lot of them spring out, as if something new is waking up. They take part in one of the most ancient human struggles: the battle of human beings against their limits. Maria Fux is not an exception. She is pushing her old body to the limits, but there's an unknown force coming from inside, that makes her still dancing. This film wants to tell the power of that force.",
            ImageUrl = "https://img.yts.mx/assets/images/movies/dancing_with_maria_2014/medium-cover.jpg",
            Price = 54.12m
          }
        );
    }
    public DbSet<Product> Products { get; set; }
  }
}
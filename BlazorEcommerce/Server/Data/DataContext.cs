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
      modelBuilder.Entity<Category>().HasData(
        new Category
        {
          Id = 1,
          Name = "Books",
          Url = "books"
        },
        new Category
        {
          Id = 2,
          Name = "Movies",
          Url = "movies"
        },
       new Category
       {
         Id = 3,
         Name = "Video Games",
         Url = "video-games"
       }
        );

      modelBuilder.Entity<Product>().HasData(
          new Product
          {
            Id = 1,
            Title = "Genji monogatari",
            Description = "Based on the classic novel by Murasaki Shikibu, written over 1000 years ago. Genji, the son of the emperor, has gained renown among the nobility of Kyoto for his charm and good looks, yet he cannot stop himself from pursuing the one object of desire he must never obtain: his father's young and beautiful bride. Following the tragic consequences of his obsession, Genji wanders from one affair to another, always seeking some sort of completion to his life. —Jean-Marc Rocher",
            ImageUrl = "https://img.yts.mx/assets/images/movies/genji_monogatari_1966/medium-cover.jpg",
            Price = 99.25m,
            CategoryId = 1
          },
          new Product
          {
            Id = 2,
            Title = "Ted K",
            Description = "Ted K lives a life of almost complete seclusion in a simple wooden cabin in the mountains of Montana. But then this former university professor, who despises modern society and its faith in technology, becomes radicalized. What begins with local acts of sabotage, ends with deadly bomb attacks. To the outside world, Ted K becomes known as the Unabomber. Based on Ted Kaczynski's diaries and writings, Tony Stone's film is a kaleidoscopic true crime journey into the life of one of America's most complex and eccentric killers. It features a tour-de-force performance from Sharlto Copley who portrays the complexity of this unique outsider, raging at the forces of both the inescapable technological society that plagues him and his own inner demons",
            ImageUrl = "https://img.yts.mx/assets/images/movies/ted_k_2021/medium-cover.jpg",
            Price = 56.25m,
            CategoryId = 1
          },
          new Product
          {
            Id = 3,
            Title = "Scream",
            Description = "Twenty-five years after the original series of murders in Woodsboro, a new Ghostface emerges, and Sidney Prescott must return to uncover the truth.",
            ImageUrl = "https://img.yts.mx/assets/images/movies/scream_2022/medium-cover.jpg",
            Price = 54.12m,
            CategoryId = 1
          },
          new Product
          {
            Id = 4,
            Title = "Dancing with Maria",
            Description = "Maria Fux is a 90 years old Argentinian dancer. In her studio in Buenos Aires she is dancing, teaching and conserving the elegance and the energy of a young performer. She gives to people in her classes the possibility to develop their own way of expressing themselves. After a period of training with her, a lot of them spring out, as if something new is waking up. They take part in one of the most ancient human struggles: the battle of human beings against their limits. Maria Fux is not an exception. She is pushing her old body to the limits, but there's an unknown force coming from inside, that makes her still dancing. This film wants to tell the power of that force.",
            ImageUrl = "https://img.yts.mx/assets/images/movies/dancing_with_maria_2014/medium-cover.jpg",
            Price = 54.12m,
            CategoryId = 1
          },
           new Product
           {
             Id = 12,
             CategoryId = 2,
             Price = 4.99m,
             Title = "The Matrix",
             Description = "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.",
             ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg",
           },
                    new Product
                    {
                      Id = 5,
                      CategoryId = 2,
                      Price = 3.99m,
                      Title = "Back to the Future",
                      Description = "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.",
                      ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg",
                    },
                    new Product
                    {
                      Id = 6,
                      CategoryId = 2,
                      Price = 2.99m,
                      Title = "Toy Story",
                      Description = "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.",
                      ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg",

                    },
                    new Product
                    {
                      Id = 7,
                      CategoryId = 3,
                      Title = "Half-Life 2",
                      Price = 49.99m,
                      Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                      ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",

                    },
                    new Product
                    {
                      Id = 8,
                      CategoryId = 3,
                      Title = "Diablo II",
                      Price = 9.99m,
                      Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                      ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                    },
                    new Product
                    {
                      Id = 9,
                      CategoryId = 3,
                      Price = 14.99m,
                      Title = "Day of the Tentacle",
                      Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                      ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                    },
                    new Product
                    {
                      Id = 10,
                      CategoryId = 3,
                      Price = 159.99m,
                      Title = "Xbox",
                      Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                      ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                    },
                    new Product
                    {
                      Id = 11,
                      CategoryId = 3,
                      Price = 79.99m,
                      Title = "Super Nintendo Entertainment System",
                      Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
                      ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                    }
        );
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
  }
}

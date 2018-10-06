using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BookManagement.Models {
    public static class SeedData {
        public static void Initialize (IServiceProvider serviceProvider) {
            using (var context = new AppDbContext (
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>> ())) {
                // GATTUSMP: SAMPLE OF A SEED FILE THAT FIRST LOOKS FOR A DATABASE WITH DATA
                //           IF NO DATA FOUND THEN DATA IS ADDED TO THE DATABASE
                // // Look for any movies.
                if (context.Book.Any ()) {
                    return; // DB has been seeded
                } else {
                    context.Book.AddRange (
                        new Book {
                            Title = "Practical Web Development",
                                Genre = "Programming",
                                Rating = 4,
                                Author = "Paul Wellens",
                                Edition = 1,
                                Price = 100.00M,
                                ISBN = "9781783552740",
                                NumberOfPages = 276,
                                Publisher = "Packt Publishing Ltd",
                                PublishedDate = DateTime.Parse ("2015-10-10")
                        },
                        new Book {
                            Title = "XML: A Manager's Guide",
                                Genre = "Programming",
                                Rating = 4,
                                Author = "Kevin Dick",
                                Edition = 1,
                                Price = 50.00M,
                                ISBN = "9781783552740",
                                NumberOfPages = 298,
                                Publisher = "Addison-Wesley Professional",
                                PublishedDate = DateTime.Parse ("2003-01-10")
                        }
                    );
                    context.SaveChanges ();
                }
                
                if (context.Patron.Any ()) {
                    return; // DB has been seeded
                } else {
                    context.Patron.AddRange (
                        new Patron {
                            Name = "Pavan Kumar",
                                PhoneNumber = "1234567890",
                                EmailId = "abc@abc.com",
                                RegistrationDate = DateTime.Parse ("2018-10-03"),
                                ExpirationDate = DateTime.Parse ("2019-10-03"),
                                Gender = "Male",
                                Country = "US"
                        });
                    context.SaveChanges ();
                }
            }

        }
    }
}
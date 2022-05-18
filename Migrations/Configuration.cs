namespace WebApplication2.Migrations
{
    using System.Data.Entity.Migrations;
    using WebApplication2.Models.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication2.Data.WebApplication2Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication2.Data.WebApplication2Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            CargarPersonas(context);
            CargarProductos(context);

        }
        private void CargarPersonas(WebApplication2.Data.WebApplication2Context db)
        {
            var data = new[] {
    new {
        Email = "mi.eleifend@outlook.couk",
        Identidad = "Grady Lewis"
    },
    new {
        Email = "dolor@hotmail.com",
        Identidad = "Tatiana Atkinson"
    },
    new {
        Email = "eleifend.egestas@yahoo.net",
        Identidad = "Athena Mann"
    },
    new {
        Email = "velit@yahoo.couk",
        Identidad = "Daquan Gibbs"
    },
    new {
        Email = "lacinia.sed.congue@aol.edu",
        Identidad = "Deborah Christensen"
    },
    new {
        Email = "dictum.phasellus@protonmail.edu",
        Identidad = "Rebekah Rios"
    },
    new {
        Email = "et@yahoo.ca",
        Identidad = "Oscar Mccray"
    },
    new {
        Email = "mus.aenean.eget@yahoo.net",
        Identidad = "Gage Craig"
    },
    new {
        Email = "tempor.lorem@aol.net",
        Identidad = "Carolyn Hawkins"
    },
    new {
        Email = "nam.ligula@protonmail.ca",
        Identidad = "Petra Gillespie"
    },
    new {
        Email = "sed@protonmail.com",
        Identidad = "Blossom Finley"
    },
    new {
        Email = "congue@aol.com",
        Identidad = "Claudia Hughes"
    },
    new {
        Email = "aenean.euismod@google.org",
        Identidad = "Connor Rojas"
    },
    new {
        Email = "nulla@google.com",
        Identidad = "Teagan Hall"
    },
    new {
        Email = "consequat.nec@icloud.ca",
        Identidad = "Lucy Castaneda"
    },
    new {
        Email = "duis@yahoo.org",
        Identidad = "Wynter Fischer"
    },
    new {
        Email = "neque.non.quam@google.com",
        Identidad = "Stacy Porter"
    },
    new {
        Email = "sit.amet@google.org",
        Identidad = "Nasim Ryan"
    },
    new {
        Email = "massa.suspendisse@aol.org",
        Identidad = "Bradley Lester"
    },
    new {
        Email = "cursus@icloud.com",
        Identidad = "Devin Ingram"
    },
    new {
        Email = "vestibulum.mauris@aol.net",
        Identidad = "Eve Griffin"
    },
    new {
        Email = "sed.neque@yahoo.ca",
        Identidad = "Anne Hahn"
    },
    new {
        Email = "a@outlook.ca",
        Identidad = "Anne Mcdowell"
    },
    new {
        Email = "lorem.luctus.ut@hotmail.com",
        Identidad = "Kameko Montgomery"
    },
    new {
        Email = "semper.et.lacinia@aol.edu",
        Identidad = "Gannon Mason"
    },
    new {
        Email = "cras.eu.tellus@protonmail.ca",
        Identidad = "Damian Waters"
    },
    new {
        Email = "lacus.ut.nec@yahoo.org",
        Identidad = "Audrey Joseph"
    },
    new {
        Email = "sit.amet@yahoo.ca",
        Identidad = "Virginia Hensley"
    },
    new {
        Email = "proin.velit@outlook.org",
        Identidad = "Trevor Cummings"
    },
    new {
        Email = "quis.tristique@hotmail.couk",
        Identidad = "Maxwell Michael"
    },
    new {
        Email = "orci@aol.ca",
        Identidad = "Sydney Mercer"
    },
    new {
        Email = "pellentesque.habitant.morbi@protonmail.couk",
        Identidad = "Azalia Daugherty"
    },
    new {
        Email = "erat@icloud.ca",
        Identidad = "Brenden Luna"
    },
    new {
        Email = "pharetra.sed@protonmail.net",
        Identidad = "Jenna Floyd"
    },
    new {
        Email = "accumsan@icloud.com",
        Identidad = "Sonya Gonzalez"
    },
    new {
        Email = "purus.ac.tellus@yahoo.com",
        Identidad = "Russell Foley"
    },
    new {
        Email = "nunc@hotmail.com",
        Identidad = "Benjamin Witt"
    },
    new {
        Email = "tempor.erat@yahoo.ca",
        Identidad = "Zeph Delaney"
    },
    new {
        Email = "donec@google.net",
        Identidad = "Kenyon Castaneda"
    },
    new {
        Email = "arcu@protonmail.com",
        Identidad = "Hedwig Ingram"
    },
    new {
        Email = "ligula@hotmail.org",
        Identidad = "Risa Yang"
    },
    new {
        Email = "erat.vel@outlook.com",
        Identidad = "Aaron Lee"
    },
    new {
        Email = "ligula.tortor.dictum@yahoo.org",
        Identidad = "Cyrus Carr"
    },
    new {
        Email = "ac@aol.com",
        Identidad = "Carolyn Allison"
    },
    new {
        Email = "elit.nulla@aol.ca",
        Identidad = "Alea Delacruz"
    },
    new {
        Email = "ipsum@yahoo.net",
        Identidad = "Imani Ayala"
    },
    new {
        Email = "sit.amet@protonmail.org",
        Identidad = "Claire Mills"
    },
    new {
        Email = "cum@aol.edu",
        Identidad = "Yasir Bass"
    },
    new {
        Email = "donec.porttitor@outlook.net",
        Identidad = "Neville Mcgee"
    },
    new {
        Email = "vel.sapien@yahoo.edu",
        Identidad = "Vance Greer"
    },
    new {
        Email = "orci.adipiscing@aol.net",
        Identidad = "Demetria Davenport"
    },
    new {
        Email = "euismod.enim@hotmail.edu",
        Identidad = "Julie Briggs"
    },
    new {
        Email = "luctus@outlook.net",
        Identidad = "Imelda Rocha"
    },
    new {
        Email = "eleifend.nec.malesuada@hotmail.couk",
        Identidad = "Zachary Holder"
    },
    new {
        Email = "dui.nec@outlook.org",
        Identidad = "Dawn Marsh"
    },
    new {
        Email = "arcu.imperdiet@google.org",
        Identidad = "Maite Fulton"
    },
    new {
        Email = "orci.sem@hotmail.net",
        Identidad = "Ray Hudson"
    },
    new {
        Email = "elit.curabitur.sed@aol.edu",
        Identidad = "Brittany Gardner"
    },
    new {
        Email = "nibh.vulputate@icloud.ca",
        Identidad = "Vera England"
    },
    new {
        Email = "tellus@outlook.edu",
        Identidad = "Austin Conley"
    },
    new {
        Email = "enim.commodo.hendrerit@yahoo.org",
        Identidad = "Bell Willis"
    },
    new {
        Email = "mollis@aol.couk",
        Identidad = "Emmanuel Gates"
    },
    new {
        Email = "et.magnis.dis@aol.edu",
        Identidad = "Brenden Suarez"
    },
    new {
        Email = "libero.integer@google.edu",
        Identidad = "Ulysses Levy"
    },
    new {
        Email = "lacus.quisque@outlook.edu",
        Identidad = "Charde Meadows"
    },
    new {
        Email = "dolor.donec@icloud.edu",
        Identidad = "Pascale Lara"
    },
    new {
        Email = "ipsum@aol.net",
        Identidad = "Farrah Snyder"
    },
    new {
        Email = "at.sem.molestie@yahoo.net",
        Identidad = "Hope Justice"
    },
    new {
        Email = "mauris.blandit.mattis@outlook.net",
        Identidad = "Zephr Mejia"
    },
    new {
        Email = "velit.aliquam@yahoo.com",
        Identidad = "Laura Jones"
    },
    new {
        Email = "nunc.interdum.feugiat@aol.couk",
        Identidad = "Imelda Mendoza"
    },
    new {
        Email = "placerat@aol.edu",
        Identidad = "Hector Moon"
    },
    new {
        Email = "fermentum.risus.at@aol.net",
        Identidad = "Aristotle Whitney"
    },
    new {
        Email = "egestas.ligula@protonmail.couk",
        Identidad = "Henry Glass"
    },
    new {
        Email = "ultricies.ornare.elit@outlook.org",
        Identidad = "Edan Dyer"
    },
    new {
        Email = "sed.leo.cras@aol.org",
        Identidad = "Constance Bauer"
    },
    new {
        Email = "consequat.purus.maecenas@hotmail.ca",
        Identidad = "Stacey Green"
    },
    new {
        Email = "felis.purus@google.net",
        Identidad = "Elijah Logan"
    },
    new {
        Email = "sapien.cras@aol.edu",
        Identidad = "Ryder Mccray"
    },
    new {
        Email = "ridiculus@protonmail.com",
        Identidad = "Robert Peterson"
    },
    new {
        Email = "sit.amet.consectetuer@protonmail.net",
        Identidad = "Nolan Newman"
    },
    new {
        Email = "at.velit.pellentesque@outlook.com",
        Identidad = "Regina Pratt"
    },
    new {
        Email = "justo.sit@hotmail.com",
        Identidad = "Steel Pope"
    },
    new {
        Email = "quam.curabitur@aol.com",
        Identidad = "Lacey Lynch"
    },
    new {
        Email = "a.mi.fringilla@yahoo.com",
        Identidad = "Brenden Hammond"
    },
    new {
        Email = "nunc@google.org",
        Identidad = "Illiana Mcconnell"
    },
    new {
        Email = "a.sollicitudin.orci@aol.edu",
        Identidad = "Cade Sherman"
    },
    new {
        Email = "ac.metus.vitae@protonmail.ca",
        Identidad = "Acton Wilson"
    },
    new {
        Email = "mauris@protonmail.ca",
        Identidad = "Britanney Watkins"
    },
    new {
        Email = "velit.dui@google.org",
        Identidad = "Perry Gardner"
    },
    new {
        Email = "mollis.non@icloud.ca",
        Identidad = "Uriah Stein"
    },
    new {
        Email = "tellus.id@outlook.com",
        Identidad = "Teegan Gamble"
    },
    new {
        Email = "neque.morbi@hotmail.com",
        Identidad = "Carol Fuller"
    },
    new {
        Email = "montes.nascetur@yahoo.edu",
        Identidad = "Oprah Young"
    },
    new {
        Email = "metus@google.edu",
        Identidad = "Eugenia Rose"
    },
    new {
        Email = "gravida.sagittis.duis@protonmail.net",
        Identidad = "Chanda Cain"
    },
    new {
        Email = "mauris.magna.duis@hotmail.net",
        Identidad = "Rhonda Holman"
    },
    new {
        Email = "duis.sit@hotmail.org",
        Identidad = "Kaseem Wiley"
    },
    new {
        Email = "tellus.faucibus.leo@hotmail.edu",
        Identidad = "Colorado Perez"
    },
    new {
        Email = "augue.scelerisque.mollis@hotmail.couk",
        Identidad = "Carla Glass"
    }
};
            foreach (var p in data)
            {
                db.Personas.AddOrUpdate(new Persona
                {
                    Identidad = p.Identidad,
                    Email = p.Email
                });
            }

            db.SaveChanges();
        }
        /*
	 * Esta funcion Precarga a todos los Productos
	 */
        private void CargarProductos(WebApplication2.Data.WebApplication2Context db)
        {
            var Productos = new[]
            {
            new Producto
            {
                NombreProducto = "Samsung Galaxy S10",
                Monto = 1500000
             },
            new Producto
            {
                NombreProducto = "Iphone 8 plus",
                Monto = 1900000
             },
            new Producto
            {
                NombreProducto = "Samsung Galaxy S22 Ultra",
                Monto = 23000000
             },
            new Producto
            {
                NombreProducto = "Redmi 9at",
                Monto = 900000
             },
            new Producto
            {
                NombreProducto = "OnePlus 6T",
                Monto = 2100000
             },
            new Producto
            {
                NombreProducto = "Samsung Galaxy S7 Edge",
                Monto = 850000
             },
            new Producto
            {
                NombreProducto = "Iphone X",
                Monto = 1500000
             },
            new Producto
            {
                NombreProducto = "Realme 6",
                Monto = 1000000
             },
            new Producto
            {
                NombreProducto = "Mi A2 Lite",
                Monto = 900000
             },
            new Producto
            {
                NombreProducto = "Mi 12 Ultra",
                Monto = 12900000
             },
            new Producto
            {
                NombreProducto = "Xperia Z1",
                Monto = 2900000
             },
            new Producto
            {
                NombreProducto = "Samsung Galaxy Z Flip",
                Monto = 15000000
             }
        };

            foreach (var i in Productos)
            {
                db.Productos.AddOrUpdate(i);
            }
            db.SaveChanges();
        }
    }
}

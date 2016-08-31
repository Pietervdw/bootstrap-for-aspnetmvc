using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Chapter7.Models;

namespace Chapter7.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            var model = GetCustomers();
            return View(model);
        }

        public List<Customer> GetCustomers()
        {
            var customers = new List<Models.Customer>
            {
                new Models.Customer() { CustomerCode = "ALFKI", CompanyName = "Alfreds Futterkiste", ContactName = "Maria Anderson", ContactTitle = "Sales Representative", Address = "Obere Str. 57", City = "Berlin", CreatedDate = new DateTime(2016,01,12) },
                new Models.Customer() { CustomerCode = "AROUT", CompanyName = "Around the Horn", ContactName = "Thomas Hardy", ContactTitle = "Sales Representative", Address = "120 Hanover Sq.", City = "London", CreatedDate = new DateTime(2015,10,14)},
                new Models.Customer() { CustomerCode = "CHOPS", CompanyName = "Chop-suey Chinese", ContactName = "Yang Wang", ContactTitle = "Owner", Address = "Hauptstr. 29", City = "Bern", CreatedDate = new DateTime(2010,7,14)},
                new Models.Customer() { CustomerCode = "EASTC", CompanyName = "Eastern Connection", ContactName = "Ann Devon", ContactTitle = "Sales Agent", Address = "35 King George", City = "London", CreatedDate = new DateTime(2015,10,15)},
                new Models.Customer() { CustomerCode = "BERGS", CompanyName = "Berglunds snabbköp", ContactName = "Christina Berglund", ContactTitle = "Order Administrator", Address = "Berguvsvägen  8", City = "Luleå", CreatedDate = new DateTime(2014,5,21)},
                new Models.Customer() { CustomerCode = "BLAUS", CompanyName = "Blauer See Delikatessen", ContactName = "Hanna Moos", ContactTitle = "Sales Representative", Address = "Forsterstr. 57", City = "Mannheim", CreatedDate = new DateTime(2011,8,20)},
                new Models.Customer() { CustomerCode = "BLONP", CompanyName = "Blondesddsl père et fils", ContactName = "Frédérique Citeaux", ContactTitle = "Marketing Manager", Address = "24, place Kléber", City = "Strasbourg", CreatedDate = new DateTime(2016,2,20)},
                new Models.Customer() { CustomerCode = "BOLID", CompanyName = "Bólido Comidas preparadas", ContactName = "Martín Sommer", ContactTitle = "Owner", Address = "C/ Araquil, 67", City = "Madrid", CreatedDate = new DateTime(2014,2,28)},
                new Models.Customer() { CustomerCode = "BONAP", CompanyName = "Bon app'", ContactName = "Laurence Lebihan", ContactTitle = "Owner", Address = "12, rue des Bouchers", City = "Marseille", CreatedDate = new DateTime(2014,4,16)},
                new Models.Customer() { CustomerCode = "BOTTM", CompanyName = "Bottom-Dollar Markets", ContactName = "Elizabeth Lincoln", ContactTitle = "Accounting Manager", Address = "23 Tsawassen Blvd.", City = "Tsawassen", CreatedDate = new DateTime(2013,2,25)},
                new Models.Customer() { CustomerCode = "BSBEV", CompanyName = "B's Beverages", ContactName = "Victoria Ashworth", ContactTitle = "Sales Representative", Address = "Fauntleroy Circus", City = "London", CreatedDate = new DateTime(2015,12,11)},
                new Models.Customer() { CustomerCode = "CACTU", CompanyName = "Cactus Comidas para llevar", ContactName = "Patricio Simpson", ContactTitle = "Sales Agent", Address = "Cerrito 333", City = "Buenos Aires", CreatedDate = new DateTime(2013,9,19)},
                new Models.Customer() { CustomerCode = "CENTC", CompanyName = "Centro comercial Moctezuma", ContactName = "Francisco Chang", ContactTitle = "Marketing Manager", Address = "Sierras de Granada 9993", City = "México D.F.", CreatedDate = new DateTime(2013,11,2)},
                new Models.Customer() { CustomerCode = "COMMI", CompanyName = "Comércio Mineiro", ContactName = "Pedro Afonso", ContactTitle = "Sales Associate", Address = "Av. dos Lusíadas, 23", City = "Sao Paulo", CreatedDate = new DateTime(2012,10,23)},
                new Models.Customer() { CustomerCode = "CONSH", CompanyName = "Consolidated Holdings", ContactName = "Elizabeth Brown", ContactTitle = "Sales Representative", Address = "Berkeley Gardens 12  Brewery", City = "London", CreatedDate = new DateTime(2012,12,27)},
                new Models.Customer() { CustomerCode = "DRACD", CompanyName = "Drachenblut Delikatessen", ContactName = "Sven Ottlieb", ContactTitle = "Order Administrator", Address = "Walserweg 21", City = "Aachen", CreatedDate = new DateTime(2010,5,1)},
                new Models.Customer() { CustomerCode = "DUMON", CompanyName = "Du monde entier", ContactName = "Janine Labrune", ContactTitle = "Owner", Address = "67, rue des Cinquante Otages", City = "Nantes", CreatedDate = new DateTime(2015,1,6)},
                new Models.Customer() { CustomerCode = "ANATR", CompanyName = "Ana Trujillo Emparedados y helados", ContactName = "Ana Trujillo", ContactTitle = "Owner", Address = "Avda. de la Constitución 2222", City = "México D.F.", CreatedDate = new DateTime(2015,1,24)},
                new Models.Customer() { CustomerCode = "ANTON", CompanyName = "Antonio Moreno Taquería", ContactName = "Antonio Moreno", ContactTitle = "Owner", Address = "Mataderos  2312", City = "México D.F.", CreatedDate = new DateTime(2011,5,19)},
                new Models.Customer() { CustomerCode = "ERNSH", CompanyName = "Ernst Handel", ContactName = "Roland Mendel", ContactTitle = "Sales Manager", Address = "Kirchgasse 6", City = "Graz", CreatedDate = new DateTime(2015,5,17)},
                new Models.Customer() { CustomerCode = "FAMIA", CompanyName = "Familia Arquibaldo", ContactName = "Aria Cruz", ContactTitle = "Marketing Assistant", Address = "Rua Orós, 92", City = "Sao Paulo", CreatedDate = new DateTime(2012,7,25)},
                new Models.Customer() { CustomerCode = "FISSA", CompanyName = "FISSA Fabrica Inter. Salchichas S.A.", ContactName = "Diego Roel", ContactTitle = "Accounting Manager", Address = "C/ Moralzarzal, 86", City = "Madrid", CreatedDate = new DateTime(2011,10,14)},
                new Models.Customer() { CustomerCode = "FOLIG", CompanyName = "Folies gourmandes", ContactName = "Martine Rancé", ContactTitle = "Assistant Sales Agent", Address = "184, chaussée de Tournai", City = "Lille", CreatedDate = new DateTime(2013,5,9)},
                new Models.Customer() { CustomerCode = "FOLKO", CompanyName = "Folk och fä HB", ContactName = "Maria Larsson", ContactTitle = "Owner", Address = "Åkergatan 24", City = "Bräcke", CreatedDate = new DateTime(2014,5,17)},
                new Models.Customer() { CustomerCode = "FRANK", CompanyName = "Frankenversand", ContactName = "Peter Franken", ContactTitle = "Marketing Manager", Address = "Berliner Platz 43", City = "München", CreatedDate = new DateTime(2014,5,23)},
                new Models.Customer() { CustomerCode = "FRANR", CompanyName = "France restauration", ContactName = "Carine Schmitt", ContactTitle = "Marketing Manager", Address = "54, rue Royale", City = "Nantes", CreatedDate = new DateTime(2015,7,18)},
                new Models.Customer() { CustomerCode = "FRANS", CompanyName = "Franchi S.p.A.", ContactName = "Paolo Accorti", ContactTitle = "Sales Representative", Address = "Via Monte Bianco 34", City = "Torino", CreatedDate = new DateTime(2011,5,4)},
                new Models.Customer() { CustomerCode = "FURIB", CompanyName = "Furia Bacalhau e Frutos do Mar", ContactName = "Lino Rodriguez", ContactTitle = "Sales Manager", Address = "Jardim das rosas n. 32", City = "Lisboa", CreatedDate = new DateTime(2016,1,12)},
                new Models.Customer() { CustomerCode = "GALED", CompanyName = "Galería del gastrónomo", ContactName = "Eduardo Saavedra", ContactTitle = "Marketing Manager", Address = "Rambla de Cataluña, 23", City = "Barcelona", CreatedDate = new DateTime(2010,8,7)},
                new Models.Customer() { CustomerCode = "GODOS", CompanyName = "Godos Cocina Típica", ContactName = "José Pedro Freyre", ContactTitle = "Sales Manager", Address = "C/ Romero, 33", City = "Sevilla", CreatedDate = new DateTime(2015,4,17)},
                new Models.Customer() { CustomerCode = "GOURL", CompanyName = "Gourmet Lanchonetes", ContactName = "André Fonseca", ContactTitle = "Sales Associate", Address = "Av. Brasil, 442", City = "Campinas", CreatedDate = new DateTime(2011,4,21)},
                new Models.Customer() { CustomerCode = "GREAL", CompanyName = "Great Lakes Food Market", ContactName = "Howard Snyder", ContactTitle = "Marketing Manager", Address = "2732 Baker Blvd.", City = "Eugene", CreatedDate = new DateTime(2014,7,13)},
                new Models.Customer() { CustomerCode = "GROSR", CompanyName = "GROSELLA-Restaurante", ContactName = "Manuel Pereira", ContactTitle = "Owner", Address = "5ª Ave. Los Palos Grandes", City = "Caracas", CreatedDate = new DateTime(2015,9,13)},
                new Models.Customer() { CustomerCode = "HANAR", CompanyName = "Hanari Carnes", ContactName = "Mario Pontes", ContactTitle = "Accounting Manager", Address = "Rua do Paço, 67", City = "Rio de Janeiro", CreatedDate = new DateTime(2011,5,13)},
                new Models.Customer() { CustomerCode = "HILAA", CompanyName = "HILARION-Abastos", ContactName = "Carlos Hernández", ContactTitle = "Sales Representative", Address = "Carrera 22 con Ave. Carlos Soublette #8-35", City = "San Cristóbal", CreatedDate = new DateTime(2013,5,3)},
                new Models.Customer() { CustomerCode = "HUNGC", CompanyName = "Hungry Coyote Import Store", ContactName = "Yoshi Latimer", ContactTitle = "Sales Representative", Address = "City Center Plaza 516 Main St.", City = "Elgin", CreatedDate = new DateTime(2011,12,18)},
                new Models.Customer() { CustomerCode = "HUNGO", CompanyName = "Hungry Owl All-Night Grocers", ContactName = "Patricia McKenna", ContactTitle = "Sales Associate", Address = "8 Johnstown Road", City = "Cork", CreatedDate = new DateTime(2016,6,18)},
                new Models.Customer() { CustomerCode = "ISLAT", CompanyName = "Island Trading", ContactName = "Helen Bennett", ContactTitle = "Marketing Manager", Address = "Garden House Crowther Way", City = "Cowes", CreatedDate = new DateTime(2014,9,13)},
                new Models.Customer() { CustomerCode = "KOENE", CompanyName = "Königlich Essen", ContactName = "Philip Cramer", ContactTitle = "Sales Associate", Address = "Maubelstr. 90", City = "Brandenburg", CreatedDate = new DateTime(2010,11,16)},
                new Models.Customer() { CustomerCode = "LACOR", CompanyName = "La corne d'abondance", ContactName = "Daniel Tonini", ContactTitle = "Sales Representative", Address = "67, avenue de l'Europe", City = "Versailles", CreatedDate = new DateTime(2011,9,11)},
                new Models.Customer() { CustomerCode = "LAMAI", CompanyName = "La maison d'Asie", ContactName = "Annette Roulet", ContactTitle = "Sales Manager", Address = "1 rue Alsace-Lorraine", City = "Toulouse", CreatedDate = new DateTime(2010,1,13)},
                new Models.Customer() { CustomerCode = "LAUGB", CompanyName = "Laughing Bacchus Wine Cellars", ContactName = "Yoshi Tannamuri", ContactTitle = "Marketing Assistant", Address = "1900 Oak St.", City = "Vancouver", CreatedDate = new DateTime(2010,11,27)},
                new Models.Customer() { CustomerCode = "LAZYK", CompanyName = "Lazy K Kountry Store", ContactName = "John Steel", ContactTitle = "Marketing Manager", Address = "12 Orchestra Terrace", City = "Walla Walla", CreatedDate = new DateTime(2010,5,26)},
                new Models.Customer() { CustomerCode = "LEHMS", CompanyName = "Lehmanns Marktstand", ContactName = "Renate Messner", ContactTitle = "Sales Representative", Address = "Magazinweg 7", City = "Frankfurt a.M.", CreatedDate = new DateTime(2010,6,3)},
                new Models.Customer() { CustomerCode = "LETSS", CompanyName = "Let's Stop N Shop", ContactName = "Jaime Yorres", ContactTitle = "Owner", Address = "87 Polk St. Suite 5", City = "San Francisco", CreatedDate = new DateTime(2012,4,14)},
                new Models.Customer() { CustomerCode = "LILAS", CompanyName = "LILA-Supermercado", ContactName = "Carlos González", ContactTitle = "Accounting Manager", Address = "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", City = "Barquisimeto", CreatedDate = new DateTime(2014,10,2)},
                new Models.Customer() { CustomerCode = "LINOD", CompanyName = "LINO-Delicateses", ContactName = "Felipe Izquierdo", ContactTitle = "Owner", Address = "Ave. 5 de Mayo Porlamar", City = "I. de Margarita", CreatedDate = new DateTime(2011,10,20)},
                new Models.Customer() { CustomerCode = "LONEP", CompanyName = "Lonesome Pine Restaurant", ContactName = "Fran Wilson", ContactTitle = "Sales Manager", Address = "89 Chiaroscuro Rd.", City = "Portland", CreatedDate = new DateTime(2011,7,3)},
                new Models.Customer() { CustomerCode = "MAGAA", CompanyName = "Magazzini Alimentari Riuniti", ContactName = "Giovanni Rovelli", ContactTitle = "Marketing Manager", Address = "Via Ludovico il Moro 22", City = "Bergamo", CreatedDate = new DateTime(2016,1,15)},
                new Models.Customer() { CustomerCode = "MAISD", CompanyName = "Maison Dewey", ContactName = "Catherine Dewey", ContactTitle = "Sales Agent", Address = "Rue Joseph-Bens 532", City = "Bruxelles", CreatedDate = new DateTime(2011,3,4)},
                new Models.Customer() { CustomerCode = "MEREP", CompanyName = "Mère Paillarde", ContactName = "Jean Fresnière", ContactTitle = "Marketing Assistant", Address = "43 rue St. Laurent", City = "Montréal", CreatedDate = new DateTime(2016,6,12)},
                new Models.Customer() { CustomerCode = "MORGK", CompanyName = "Morgenstern Gesundkost", ContactName = "Alexander Feuer", ContactTitle = "Marketing Assistant", Address = "Heerstr. 22", City = "Leipzig", CreatedDate = new DateTime(2013,1,4)},
                new Models.Customer() { CustomerCode = "NORTS", CompanyName = "North/South", ContactName = "Simon Crowther", ContactTitle = "Sales Associate", Address = "South House 300 Queensbridge", City = "London", CreatedDate = new DateTime(2016,2,8)},
                new Models.Customer() { CustomerCode = "OCEAN", CompanyName = "Océano Atlántico Ltda.", ContactName = "Yvonne Moncada", ContactTitle = "Sales Agent", Address = "Ing. Gustavo Moncada 8585 Piso 20-A", City = "Buenos Aires", CreatedDate = new DateTime(2015,3,11)},
                new Models.Customer() { CustomerCode = "OLDWO", CompanyName = "Old World Delicatessen", ContactName = "Rene Phillips", ContactTitle = "Sales Representative", Address = "2743 Bering St.", City = "Anchorage", CreatedDate = new DateTime(2014,7,18)}
            };

            return customers;
        }

        public IActionResult Test()
        {
            var model = GetCustomers();
            return View(model);
        }

        public IActionResult Test2()
        {
            var model = GetCustomers();
            return View(model);
        }


    }
}

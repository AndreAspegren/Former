namespace Former
{
    class Start
    {
        public static void Main(string[] args)
        {
            new App().run();
        }
    }

    class App
    {
        private List<Former> former = new List<Former>()
        {
            new Rektangel("kek", "blå", 3, 3),
            new Rektangel("wow", "grønn", 5.234234, 3.342334),
            new Sirkel("sykt", "oransj", 3.14),
            new Sirkel("liksom", "rosa", 6.55),
            new Trekant("yes", "blå", 4, 20.34)
        };

        internal void run()
        {
            foreach (var form in former)
            {
                Console.WriteLine($@"Navnet er:{form._name} 
Fargen er: {form._color} 
Arealet er: {form.calculateArea()}
");
                double totalArea = 0;
                foreach (var num in former)
                {
                    totalArea += num.calculateArea();
                }
                Console.WriteLine($@"Totalarealet av alle formene er: {totalArea}
");

                var areaList = listByArea();

                Console.WriteLine("Liste basert på areal:");
                foreach (var area in areaList)
                {
                    Console.WriteLine(@$"{area._name}, {area.calculateArea()}");
                }
                Console.WriteLine("");
                Console.WriteLine("Liste basert på farge:");
                var colorList = listByColor();
                foreach (var group in colorList)
                {
                    Console.WriteLine($"Farge: {group.Key}, Antall: {group.Count()}");
                    foreach (var kek in group) Console.WriteLine($"  Navn: {kek._name}");
                }
            }
        }
        private List<Former> listByArea()
        {
            return former.OrderBy(form => form.calculateArea()).ToList();
        }
        private IEnumerable<IGrouping<string, Former>> listByColor()
        {
            return former.GroupBy(form => form._color).OrderBy(group => group.Key);
        }
    }
}

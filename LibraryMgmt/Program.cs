namespace LibraryMgmt;

class Program
{
    static void Main(string[] args)
    {
        Library myLibrary = new Library("Central City Library");
        Console.WriteLine("### Library Item Management (Phase 1 & 2 Demo) ###\n");
        
        Console.WriteLine("--- Creating Library Items ---");
        Book lordOfTheRings = new Book("J.R.R. Tolkien", "978-0618260274", "B001", "The Lord of the Rings");
        Magazines natGeo = new Magazines("M005", "National Geographic", 321, new DateTime(2024, 5, 1));
        Book hobbit = new Book("J.R.R. Tolkien", "B002", "978-0345339683","The Hobbit");
        
        myLibrary.AddItem(lordOfTheRings);
        myLibrary.AddItem(natGeo);
        myLibrary.AddItem(hobbit);
        
        myLibrary.DisplayAllItems();
        
        // Console.WriteLine("\n--- Displaying Item Info ---");
        // lordOfTheRings.DisplayInfo();
        // Console.WriteLine($"Summary: {lordOfTheRings.GetSummary()}\n");
        //
        // natGeo.DisplayInfo();
        // Console.WriteLine($"Summary: {natGeo.GetSummary()}\n");
        //
        // hobbit.DisplayInfo();
        // Console.WriteLine($"Summary: {hobbit.GetSummary()}\n");

        
        Console.WriteLine("\n--- Testing Loanable Behavior ---");
        
        Console.WriteLine($"Is '{lordOfTheRings.Title}' on loan? {lordOfTheRings.IsOnLoan}");
        Console.WriteLine($"Is '{natGeo.Title}' on loan? {natGeo.IsOnLoan}");
        
        Console.WriteLine("\nAttempting to loan 'The Lord of the Rings' to Member 'MEM001'...");
        lordOfTheRings.Loan("MEM001", new DateTime(2025, 5, 25), new DateTime(2025, 6, 8));

        Console.WriteLine($"Is '{lordOfTheRings.Title}' on loan? {lordOfTheRings.IsOnLoan}");
        Console.WriteLine($"Borrower: {lordOfTheRings.CurrentBorrowerId}");
        Console.WriteLine($"Due Date: {lordOfTheRings.DueDate?.ToShortDateString()}");
        
        Console.WriteLine("\nAttempting to loan 'The Lord of the Rings' again...");
        lordOfTheRings.Loan("MEM002", new DateTime(2025, 5, 26), new DateTime(2025, 6, 9));
        
        Console.WriteLine("\nAttempting to loan 'National Geographic' to Member 'MEM003'...");
        natGeo.Loan("MEM003", new DateTime(2025, 5, 20), new DateTime(2025, 5, 27)); // Due May 27th
        
        Console.WriteLine("\nAttempting to return 'The Lord of the Rings'...");
        lordOfTheRings.Return(new DateTime(2025, 6, 5));

        Console.WriteLine($"Is '{lordOfTheRings.Title}' on loan? {lordOfTheRings.IsOnLoan}");

        
        Console.WriteLine("\nAttempting to return 'National Geographic'...");
        natGeo.Return(new DateTime(2025, 5, 28));


        Console.WriteLine("\n### End of Library Item Demo ###");
        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}
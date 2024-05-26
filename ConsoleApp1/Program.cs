using Interface_Segregation_Principle;

IPrinter printer = new Printer();
IScanner scanner = new Scanner();

printer.Print(); 
scanner.Scan();
/// start main
int userChoice = GetUserChoice();
while(userChoice!=3){
    RouteEm(userChoice);
    userChoice = GetUserChoice();
}
// end main
static int GetUserChoice()
{
    DisplayMenu();
    string userChoice = Console.ReadLine();
    if(IsValidChoice(userChoice)) {
        return int.Parse(userChoice);
    }
    else return 0;
}
static void DisplayMenu()
{
    
    Console.Clear();
    System.Console.WriteLine("Enter 1 to Display a Full Triangle\nEnter 2 to Display a Partial Triangle\nEnter 3 to Exit");
}
static bool IsValidChoice(string userInput)
{
    if(userInput== "1" || userInput =="2" || userInput=="3"){
        return true;
    }
    return false;

}
static void GetFull() 
{
    Console.Clear();
    int number = GetRandom();
    int k = GetRandomer();
    for(int i = 0; i < k; i++) {
        for(int j = 0; j < i; j++) {
            Console.Write(number);
        }
        System.Console.WriteLine(number);
    }
    PauseAction();
}
static void GetPartial()
{
    Console.Clear();
    int number = GetRandom();
    int k = GetRandomer();
    int f = number;
    for(int i = 0; i < k; i++) {
        for(int j = 0; j < i; j++) {
        number = GetRandom();
        if(number==f) {
            Console.Write(number);
        }
        else Console.Write(" ");
        }
        System.Console.WriteLine(f);
    }
    PauseAction();
}
static void SayInvalid()
{
    System.Console.WriteLine("Invalid!");
    PauseAction();
}
static void RouteEm(int menuChoice){
    if(menuChoice==1){
        GetFull();
    }
    else if(menuChoice==2){
        GetPartial();
    }
    else if(menuChoice!=3) {
        SayInvalid();
    }

}
static void PauseAction(){
    System.Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}
static int GetRandom() {
    Random rand = new Random();
    int number = rand.Next(2);
    return number;
}
static int GetRandomer() {
    Random rand = new Random();
    int k = rand.Next(3,9);
    return k;
}
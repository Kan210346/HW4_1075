class Program
{
    public static Stack<string> BlueEyesWhiteDragon = new Stack<string>();

    public static Tree<string> Exodia = new Tree<string>();
    public static void Getperson(string lastpers){
        int person = int.Parse(Console.ReadLine());
        if(person != 0){

            string Yubel = Console.ReadLine();
            Exodia.AddChild(lastpers , Yubel);
            Getperson(Yubel);
            BlueEyesWhiteDragon.Push(Yubel);

            if(person >= 1){
                for(int i = 1 ; i < person ; i++){
                    string Neous = Console.ReadLine();
                    Exodia.AddSibling(BlueEyesWhiteDragon.Pop() , Neous);
                    Getperson(Neous);
                    BlueEyesWhiteDragon.Push(Neous);
                }
            }
        }
    }
    static void Main(string[] args){
        string Kuribo = Console.ReadLine();
        Exodia.AddChild(null , Kuribo);
        Getperson(Kuribo);
        string output = Console.ReadLine();
        Queue<string> eiei = Exodia.ShowBoost(output);
        int i = 0;
        while(i <= eiei.GetLength()){
            Console.WriteLine(eiei.Pop());
            i++;
        }
    }
}
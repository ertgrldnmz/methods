internal class Program
{
    private static void Main(string[] args)
    {
        //erişim belirteci geri_dönüş tipi method_adı(parametreler listesi/arguman)
        //{
            // komutlar;

        //}

        int a=2;
        int b=3;
        
        Console.WriteLine(a+b);
        int sonuc=Topla(a,b);
        Console.WriteLine(sonuc);
        
        Methods method=new Methods();
        method.Ekrana_Yazdır(sonuc.ToString());

        
        int sonuc2=method.ArttırveTopla(a,b);
         method.Ekrana_Yazdır(sonuc2.ToString());
        int sonuc3=method.RefArttırveTopla(ref a,ref b);
         method.Ekrana_Yazdır((a+b).ToString());
         




    }

   static int Topla(int deger1,int deger2)
    {
        return deger1+deger2;
    }

}
 class Methods
{
     public void Ekrana_Yazdır(string veri)
    {
        Console.WriteLine(veri);
    }
    public int ArttırveTopla(int deger1,int deger2)
    {
        deger1+=1;
        deger2+=1;
        return deger1+deger2;
    }

     public int RefArttırveTopla(ref int deger1,ref int deger2)
    {
        deger1+=1;
        deger2+=1;
        return deger1+deger2;
    }
}
using System;
using System.Collections.Generic;

namespace Project_Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true){
                Console.WriteLine("Inserte nro del problema:");
                string input = Console.ReadLine();

                if(input!= "--help"){
                    int num= Convert.ToInt32(input);
                    switch(num){
                        case 1: Problema1();
                                break;
                        case 2: Problema2();
                                break;
                        case 3: Problema3();
                                break;
                    }

                    break;
                }else{
                    Console.WriteLine("Valor incorrecto, intente de nuevo");
                }

            }
            
        }

        public static void Problema1(){
            int sum=0;
            for(int i=0; i<1000; i++){
                if(i%3==0 || i%5==0){
                    sum+=i;
                }
            }
            Console.WriteLine("Suma de numeros multiplos de 3 o 5 menores a 1000: "+sum);

        }

        public static void Problema2(){
            int sum=0, num1=1, num2=1, prev=1;

            while(num1<4000000){
                if(num1%2==0){
                    sum+=num1;
                }
                num2=prev;
                prev=num1;
                num1=prev+num2;  
            }

            Console.WriteLine("Suma de numeros: "+sum);
        }

        public static void Problema3(){
            long max=0;

            for(long i=100; i>0; i--){
                int multiplos=0;
                long j=1;
                while(multiplos<=2 && j<i){
                    if(i%j==0){
                        multiplos++;
                    }
                    j++;
                }

                if(multiplos==1){
                    max=i;
                    break;
                }
            }
            Console.Write(max);
        }

    }

}

using System;

namespace AlekseiPalma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la cocina; hoy cocinaremos Pastel de Tallarines");
            Console.ReadLine();

            Estanteria();
        }

        public static void Estanteria()
        {
            string Respuesta;

            Console.WriteLine("Comencemos por ir a la estanteria a sacar unos cuantos ingredientes");
            Console.WriteLine("Parece que aqui estan los fideos, la sal, la pimineta y el aceite");
            Console.WriteLine("¿Deseas ver el valor nutricional de alguno de estos ingredientes? Escriba <O> para si y <X> para no");

            Respuesta = Console.ReadLine().ToUpper();

            if (Respuesta == "O")
            {
                Console.WriteLine("Escribe <FIDEOS> , <SAL> , <PIMIENTA> , <ACEITE> o <X> para continuar");
                Respuesta = Console.ReadLine().ToUpper();

                if (Respuesta == "FIDEOS")
                {
                    Console.WriteLine("Calorias: 138");
                    Console.WriteLine("Grasas: 2.1g");
                    Console.WriteLine("Colesterol: 29g");
                    Console.WriteLine("Sodio: 5mg");
                    Console.WriteLine("Potasio: 38mg");
                    Console.WriteLine("Carbohidratos: 25g");
                    Console.WriteLine("Proteinas: 4.5g");
                    Console.WriteLine("Vitaminas: 29IU");
                    Console.WriteLine("Calcio: 12mg");
                    Console.WriteLine("Hierro: 1.5mg");
                    Console.WriteLine("Magnesio: 21mg");
                    Console.WriteLine(" ");
                    Console.WriteLine("¿Deseas ver el valor nutricional de algun otro ingrediente? Escriba <O> para si y <X> para no");
                    Respuesta = Console.ReadLine().ToUpper();

                    if (Respuesta == "O")
                    {
                        Estanteria();
                    }
                    else if (Respuesta == "X")
                    {
                        Refrigerador();
                    }
                }
                else if (Respuesta == "SAL")
                {
                    Console.WriteLine("Calorias: 0");
                    Console.WriteLine("Grasas: 2g");
                    Console.WriteLine("Colesterol: 0g");
                    Console.WriteLine("Sodio: 38,758mg");
                    Console.WriteLine("Potasio: 8mg");
                    Console.WriteLine("Carbohidratos: 0g");
                    Console.WriteLine("Proteinas: 4g");
                    Console.WriteLine("Vitaminas: 0IU");
                    Console.WriteLine("Calcio: 24mg");
                    Console.WriteLine("Hierro: 0.3mg");
                    Console.WriteLine("Magnesio: 1mg");
                    Console.WriteLine(" ");
                    Console.WriteLine("¿Deseas ver el valor nutricional de algun otro ingrediente? Escriba <O> para si y <X> para no");
                    Respuesta = Console.ReadLine().ToUpper();

                    if (Respuesta == "O")
                    {
                        Estanteria();
                    }
                    else if (Respuesta == "X")
                    {
                        Refrigerador();
                    }
                }
                else if (Respuesta == "PIMIENTA")
                {
                    Console.WriteLine("Calorias: 251");
                    Console.WriteLine("Grasas: 3.3g");
                    Console.WriteLine("Colesterol: 0g");
                    Console.WriteLine("Sodio: 20mg");
                    Console.WriteLine("Potasio: 1.329mg");
                    Console.WriteLine("Carbohidratos: 64g");
                    Console.WriteLine("Proteinas: 10g");
                    Console.WriteLine("Vitaminas: 560IU");
                    Console.WriteLine("Calcio: 443mg");
                    Console.WriteLine("Hierro: 9.7mg");
                    Console.WriteLine("Magnesio: 171mg");
                    Console.WriteLine(" ");
                    Console.WriteLine("¿Deseas ver el valor nutricional de algun otro ingrediente? Escriba <O> para si y <X> para no");
                    Respuesta = Console.ReadLine().ToUpper();

                    if (Respuesta == "O")
                    {
                        Estanteria();
                    }
                    else if (Respuesta == "X")
                    {
                        Refrigerador();
                    }
                }
                else if (Respuesta == "ACEITE")
                {
                    Console.WriteLine("Calorias: 884");
                    Console.WriteLine("Grasas: 100g");
                    Console.WriteLine("Colesterol: 0g");
                    Console.WriteLine("Sodio: 0mg");
                    Console.WriteLine("Potasio: 0mg");
                    Console.WriteLine("Carbohidratos: 0g");
                    Console.WriteLine("Proteinas: 0g");
                    Console.WriteLine("Vitaminas: 0IU");
                    Console.WriteLine("Calcio: 0mg");
                    Console.WriteLine("Hierro: 0mg");
                    Console.WriteLine("Magnesio: 0mg");
                    Console.WriteLine(" ");
                    Console.WriteLine("¿Deseas ver el valor nutricional de algun otro ingrediente? Escriba <O> para si y <X> para no");
                    Respuesta = Console.ReadLine().ToUpper();

                    if (Respuesta == "O")
                    {
                        Estanteria();
                    }
                    else if (Respuesta == "X")
                    {
                        Refrigerador();
                    }
                }

            }
            else if (Respuesta == "X")
            {
                Refrigerador();
            }
        }

        public static void Refrigerador()
        {
            string Respuesta;
            Electrohogar electrohogar = new Electrohogar();

            Console.WriteLine("Ok, dirijamonos al refrigerador");
            Console.WriteLine("Aqui esta el queso, los huevos y el agua");
            Console.WriteLine("Podemos ver el valor nutricional de estos y tambien cambiar la temperatura");
            Console.WriteLine("¿Deseas hacer alguna de las cosas? Escriba <O> para si y <X> para no");

            Respuesta = Console.ReadLine().ToUpper();

            if (Respuesta == "O")
            {
                Console.WriteLine("Escribe <QUESO> , <HUEVOS> , <AGUA> , <TEMP> o <X> para continuar");
                Respuesta = Console.ReadLine().ToUpper();

                if (Respuesta == "QUESO")
                {
                    Console.WriteLine("Calorias: 402");
                    Console.WriteLine("Grasas: 33g");
                    Console.WriteLine("Colesterol: 105mg");
                    Console.WriteLine("Sodio: 621mg");
                    Console.WriteLine("Potasio: 98mg");
                    Console.WriteLine("Carbohidratos: 1.3g");
                    Console.WriteLine("Proteinas: 25g");
                    Console.WriteLine("Vitaminas: 62IU");
                    Console.WriteLine("Calcio: 721mg");
                    Console.WriteLine("Hierro: 0.7mg");
                    Console.WriteLine("Magnesio: 28mg");
                    Console.WriteLine(" ");
                    Console.WriteLine("¿Deseas ver el valor nutricional de algun otro ingrediente? Escriba <O> para si y <X> para no");
                    Respuesta = Console.ReadLine().ToUpper();

                    if (Respuesta == "O")
                    {
                        Refrigerador();
                    }
                    else if (Respuesta == "X")
                    {
                        Mesa();
                    }
                }
                else if (Respuesta == "HUEVOS")
                {
                    Console.WriteLine("Calorias: 155");
                    Console.WriteLine("Grasas: 11g");
                    Console.WriteLine("Colesterol: 373mg");
                    Console.WriteLine("Sodio: 124mg");
                    Console.WriteLine("Potasio: 126mg");
                    Console.WriteLine("Carbohidratos: 1.1g");
                    Console.WriteLine("Proteinas: 13g");
                    Console.WriteLine("Vitaminas: 655IU");
                    Console.WriteLine("Calcio: 50mg");
                    Console.WriteLine("Hierro: 1.2mg");
                    Console.WriteLine("Magnesio: 10mg");
                    Console.WriteLine(" ");
                    Console.WriteLine("¿Deseas ver el valor nutricional de algun otro ingrediente? Escriba <O> para si y <X> para no");
                    Respuesta = Console.ReadLine().ToUpper();

                    if (Respuesta == "O")
                    {
                        Refrigerador();
                    }
                    else if (Respuesta == "X")
                    {
                        Mesa();
                    }
                }
                else if (Respuesta == "AGUA")
                {
                    Console.WriteLine("Calorias: 0");
                    Console.WriteLine("Grasas: 0g");
                    Console.WriteLine("Colesterol: 0mg");
                    Console.WriteLine("Sodio: 5mg");
                    Console.WriteLine("Potasio: 0mg");
                    Console.WriteLine("Carbohidratos: 0g");
                    Console.WriteLine("Proteinas: 0g");
                    Console.WriteLine("Vitaminas: 0IU");
                    Console.WriteLine("Calcio: 3mg");
                    Console.WriteLine("Hierro: 0mg");
                    Console.WriteLine("Magnesio: 1mg");
                    Console.WriteLine(" ");
                    Console.WriteLine("¿Deseas ver el valor nutricional de algun otro ingrediente? Escriba <O> para si y <X> para no");
                    Respuesta = Console.ReadLine().ToUpper();

                    if (Respuesta == "O")
                    {
                        Refrigerador();
                    }
                    else if (Respuesta == "X")
                    {
                        Mesa();
                    }
                }
                else if (Respuesta == "TEMP")
                {
                    electrohogar.AjustarTemperatura();
                }
            }
            else if(Respuesta == "X")
            {
                Mesa();
            }
        }

        public static void Mesa()
        {
            ArticulosDeLimpieza articulosDeLimpieza = new ArticulosDeLimpieza();

            Console.WriteLine("Vamos a dejar los fideos cocinando mientras lavamos los utensilios y demas ingredientes en el lavadero");
            Console.WriteLine("Una vez lavado lo secaremos con papel toalla");

            articulosDeLimpieza.SacarHoja();
        }

        public static void Preparar()
        {
            Console.WriteLine("Ahora batemos el huevo, cortamos el queso...");
            Console.WriteLine("Y con el tallarin ya listo lo colocamos en una sarten con aceite");
            Console.WriteLine("Vertimos el huevo sobre el tallarin, agregamos queso, repetimos una vez mas");
            Console.WriteLine("Le damos la vueta una vez se cocino ese lado, dejamos cocinar el otro y listo");
            Console.WriteLine("Nuestro Pastel de Tallarines esta listo");

            Console.ReadLine();
        }
    }
}

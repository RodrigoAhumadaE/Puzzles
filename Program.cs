// <<<Matriz Aleatoria>>>
/* Crear una función llamada RandomArray() que devuelva una matriz de enteros​

Crea una matriz vacía que contenga 10 valores enteros.​
Recorre la matriz y asigna a cada índice un valor entero aleatorio entre 5 y 25.​
Imprime los valores mínimo y máximo de la matriz.​
Imprime la suma de todos los valores.​ */

static void RandomArray(){
  int[] matriz = new int[10];
  Random rand = new Random();
  for(int i=0; i<matriz.Length; i++){
    matriz[i] = rand.Next(5,26);
  }
  int min = matriz[0];
  int max = matriz[0];
  foreach(int valor in matriz){
    if(valor < min){
      min = valor;
    }
    if(valor > max){
      max = valor;
    }
  }
  Console.WriteLine($"Valor mínimo de la matriz: {min}\nValor máximo de la matriz: {max}");
  int sum = 0;
  foreach(int valor in matriz){
    sum += valor;
  }
  Console.WriteLine($"Suma de los valores de la matriz: {sum}");
}

RandomArray();

// <<<Lanzamiento de Moneda>>>
/* Crear una función llamada TossCoin() que devuelva una cadena. ​
Que la función imprima "¡Tirando una moneda!".​
Lanzar una moneda al azar con un resultado que señale cualquiera de las dos caras de la moneda. ​
Haz que la función imprima "Cara" o "Cruz".​
Por último, devuelve el resultado. ​ */

static string TossCoin(){
  Console.WriteLine("¡Tirando una moneda!");
  Random rand = new Random();
  int valor = rand.Next(2);
  string moneda;
  if(valor == 0){
    moneda = "Cruz";
  }else{
    moneda = "Cara";
  }
  Console.WriteLine(moneda);
  return moneda;
}

string resultado = TossCoin();
Console.WriteLine("-------------------");

// Opcional:
/* Crea otra función llamada TossMultipleCoins(int num) que devuelva un Doble. ​
Haz que la función llame a la función tossCoin varias veces en función del valor num.​
Haz que la función devuelva un Doble que refleje la relación entre el lanzamiento de cabezas y el lanzamiento total.​ */

static double TossMultipleCoins(int num){
  string[] lanzamiento = new string[num];
  double cont = 0;  
  for(int i=0; i<num; i++){
    lanzamiento[i] = TossCoin();
    if(lanzamiento[i] == "Cara"){
      cont++;
    }
  }
  if(cont != 0){
    return num/cont;
  }else{    
    return 0;
  }  
}

double resp = Math.Round(TossMultipleCoins(8), 2);
Console.WriteLine($"Realcion entre resultados Cara y tolal de lanzamientos es {resp}");

// <<<Nombres>>>
/* Construye una función Nombres que devuelva una lista de cadenas. En esta función:​
Crea una lista con los valores Todd, Tiffany, Charlie, Ginebra, Sydney. ​
Devuelve una lista que solo incluya nombres de más de 5 caracteres. */

static List<string> Nombres(){
  List<string> listNombres = new List<string>(){"Todd", "Tiffany", "Charlie", "Ginebra", "Sydney"};
  List<string> bigNombres = new List<string>();
  foreach(string nombre in listNombres){
    if(nombre.Length > 5){
      bigNombres.Add(nombre);
    }
  }
  return bigNombres;
}

List<string> nombres = new List<string>();
nombres = Nombres();
foreach(string nom in nombres){
  Console.WriteLine(nom);
}

// Opcional
/* Baraja la lista e imprime los valores en el nuevo orden.  */
Console.WriteLine("---------------");
static void ListaBarajada(List<string> nombres){
  Random rand = new Random();
  int i = nombres.Count;
  while(i > 1){
    i--;
    int j = rand.Next(i+1);
    string aux = nombres[j];
    nombres[j] = nombres[i];
    nombres[i] = aux;
  }
  foreach(string nombre in nombres){
    Console.WriteLine(nombre);
  }
}

ListaBarajada(nombres);
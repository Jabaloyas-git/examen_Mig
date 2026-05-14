using System;
using System.Windows.Forms;

namespace Ejercicio3_Refactorizacion
{
    public partial class FormRefactorizacion : Form
    {
        public FormRefactorizacion()
        {
            InitializeComponent();
            CargarErrores();
            CargarCodigos();
        }

        private void CargarErrores()
        {
            dgvErrores.Rows.Add("#01", "Convención nombres",
                "Variable 'ALUMNO' en MAYÚSCULAS. Las variables locales deben ir en camelCase.",
                "string nombreAlumno = \"Juan\";");
            dgvErrores.Rows.Add("#02", "Uso de variables",
                "new String(\"...\") es redundante en C# y Java. Basta con usar un literal.",
                "string materia = \"Matemáticas\";");
            dgvErrores.Rows.Add("#03", "Convención nombres",
                "Variable 'x' no tiene significado. Dificulta la lectura del código.",
                "int notaBase = 8;");
            dgvErrores.Rows.Add("#04", "Lógica / Tipos",
                "5/2 = 2 (división entera en Java/C#). resultado = 10, no 10.5 como se esperaba.",
                "double resultado = notaBase + 5.0 / 2;  // → 10.5");
            dgvErrores.Rows.Add("#05", "Uso de variables",
                "'x = 18' reasigna la variable pero ese valor NUNCA se usa después (dead code).",
                "Eliminar la línea 'x = 18;'");
            dgvErrores.Rows.Add("#06", "Tipo de dato",
                "'boolean' es Java. En C# el tipo booleano se llama 'bool'.",
                "bool esAlumnoMenor = true;");
            dgvErrores.Rows.Add("#07", "Lógica / Duplicación",
                "El bloque if(esNiño) aparece dos veces con idéntico contenido (código duplicado).",
                "Un único bloque if(esAlumnoMenor) { ... }");
            dgvErrores.Rows.Add("#08", "Formato / Legibilidad",
                "El bucle for está comprimido en una sola línea sin sangría ni llaves propias.",
                "for (int i = 0; i < 10; i++)\n{\n    Console.WriteLine(i);\n}");
            dgvErrores.Rows.Add("#09", "Mantenibilidad",
                "String de normativa demasiado largo escrito directamente en el código (magic string).",
                "private const string NORMATIVA_EVALUACION = \"...\";");
            dgvErrores.Rows.Add("#10", "Lógica redundante",
                "'esNiño == true' es innecesario. Un bool ya es verdadero o falso por sí solo.",
                "if (esAlumnoMenor) { ... }");
        }

        private void CargarCodigos()
        {
            txtOriginal.Text =
"// ====== CÓDIGO ORIGINAL (con 10 errores) ======\r\n\r\n" +
"public class Escuela {\r\n" +
"  public void evaluarAlumno(){\r\n" +
"    String ALUMNO = \"Juan\";                    // ERROR 1: MAYUSCULAS\r\n" +
"    String materia = new String(\"Matemáticas\"); // ERROR 2: new String() innecesario\r\n" +
"    int x = 8;                                  // ERROR 3: nombre 'x' sin semántica\r\n" +
"    double resultado = x + 5/2;                 // ERROR 4: 5/2=2 (entero), no 2.5\r\n" +
"    x = 18;                                     // ERROR 5: dead code, nunca se usa\r\n" +
"\r\n" +
"    if (resultado < 4.9){\r\n" +
"      imprimirBoletin(\"Suspenso\",0,\"Repasar\",true,0,\"Tutoria\");\r\n" +
"    }\r\n" +
"\r\n" +
"    boolean esNiño = true;                      // ERROR 6: boolean es Java, no C#\r\n" +
"\r\n" +
"    if(esNiño){                                 // ERROR 7: bloque duplicado (1ª vez)\r\n" +
"      System.out.println(\"Correo padres...\");\r\n" +
"    }\r\n" +
"\r\n" +
"    for(int i=0;i<10;i++){System.out.println(i);}  // ERROR 8: sin formato\r\n" +
"\r\n" +
"    String normativa = \"según el articulo 34...\";  // ERROR 9: magic string\r\n" +
"\r\n" +
"    if(esNiño==true){                          // ERROR 10: comparación redundante\r\n" +
"      System.out.println(\"Correo padres...\"); // ERROR 7: bloque duplicado (2ª vez)\r\n" +
"    }\r\n" +
"\r\n" +
"    imprimirBoletin(\"Aprobado\",10,\"Bien\",false,0,\"Casa\");\r\n" +
"  }\r\n" +
"\r\n" +
"  public void imprimirBoletin(String estado, int código,\r\n" +
"      String observación, boolean firma, int copias, String destino){\r\n" +
"    System.out.println(estado);\r\n" +
"  }\r\n" +
"}";

            txtRefactorizado.Text =
"// ====== CÓDIGO REFACTORIZADO (10 errores corregidos) ======\r\n\r\n" +
"public class Escuela\r\n" +
"{\r\n" +
"    // FIX 9: constante con nombre descriptivo\r\n" +
"    private const string NORMATIVA_EVALUACION =\r\n" +
"        \"Según el artículo 34 de la normativa vigente...\";\r\n" +
"\r\n" +
"    private const double NOTA_MINIMA_APROBADO = 5.0;\r\n" +
"\r\n" +
"    public void EvaluarAlumno()   // PascalCase para métodos\r\n" +
"    {\r\n" +
"        string nombreAlumno = \"Juan\";       // FIX 1+2: camelCase, sin new String()\r\n" +
"        string materia = \"Matemáticas\";\r\n" +
"        int notaBase = 8;                    // FIX 3: nombre descriptivo\r\n" +
"        double resultado = notaBase + 5.0/2; // FIX 4: resultado = 10.5\r\n" +
"                                             // FIX 5: eliminado 'x = 18'\r\n" +
"\r\n" +
"        if (resultado < NOTA_MINIMA_APROBADO)\r\n" +
"        {\r\n" +
"            ImprimirBoletin(\"Suspenso\", 0, \"Repasar\", true, 0, \"Tutoría\");\r\n" +
"        }\r\n" +
"\r\n" +
"        bool esAlumnoMenor = true;           // FIX 6: 'bool' de C#\r\n" +
"\r\n" +
"        if (esAlumnoMenor)                   // FIX 7+10: un bloque, sin ==true\r\n" +
"        {\r\n" +
"            Console.WriteLine(\"Correo padres...\");\r\n" +
"        }\r\n" +
"\r\n" +
"        // FIX 8: formato correcto\r\n" +
"        for (int i = 0; i < 10; i++)\r\n" +
"        {\r\n" +
"            Console.WriteLine(i);\r\n" +
"        }\r\n" +
"\r\n" +
"        Console.WriteLine(NORMATIVA_EVALUACION); // FIX 9\r\n" +
"\r\n" +
"        ImprimirBoletin(\"Aprobado\", 10, \"Bien\", false, 0, \"Casa\");\r\n" +
"    }\r\n" +
"\r\n" +
"    public void ImprimirBoletin(string estado, int codigo,\r\n" +
"        string observacion, bool requiereFirma, int copias, string destino)\r\n" +
"    {\r\n" +
"        Console.WriteLine(estado);\r\n" +
"    }\r\n" +
"}";
        }
    }
}

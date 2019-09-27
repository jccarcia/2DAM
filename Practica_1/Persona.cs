using System;

public class Persona
{
    //Atributos de la clase Persona
    private String dni, nombre, apellidos;
    private DateTime fechanaci;
    private decimal peso, altura;

    //Getters y Setters de los atributos
    public string Dni { get => dni; set => dni = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellidos { get => apellidos; set => apellidos = value; }
    public decimal Peso { get => peso; set => peso = value; }
    public decimal Altura { get => altura; set => altura = value; }
    public DateTime Fechanaci { get => fechanaci; set => fechanaci = value; }

    //Constructor con parametros
    public Persona(string dni, string nombre, string apellido, DateTime fechanaci, decimal peso, decimal altura)
    {
        this.Dni = dni;
        this.Nombre = nombre;
        this.Apellidos = apellido;
        this.Fechanaci = fechanaci;
        this.Peso = peso;
        this.Altura = altura;
    }

    //Constructor base sin parametros
    public Persona()
    {
    }

    public override string ToString()
    {
        String resul = "";
        resul += "DNI: " + dni + "\r\n";
        resul += "Nombre: " + nombre + "\r\n";
        resul += "Apellidos: " + apellidos + "\r\n";
        resul += "Fecha de nacimiento: " + fechanaci + " Peso: " + peso + " Altura: " + altura + "\r\n" + "\r\n";
        return resul;
    }
}
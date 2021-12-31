using System;

public class Materia : ICloneable
{
    public int Codigo { get; set; }
    public string Denominacion { get; set; }
    protected int Nota { get; set; }
    protected Alumno Al { get; set; }
    public object Clone() { return this.MemberwiseClone(); }
    public void Apuntar_alumno(Alumno A) { Al = A; }
    public Alumno Leer_alumno_apuntado() { return Al; }
    public int Obtener_nota() { return Nota; }
    public void Cargar_nota(int pNota)
    {


        if (this is Especializada && pNota >= 6 && pNota <= 9)
        { Nota = pNota + 1; }
        else { Nota = pNota; }

    }
}


public class Notas
{
  public List<float> notas;
  public float media 
  {
    get 
    {
      if (notas != null && notas.Count > 0)
      {
        float m = 0;
        notas.ForEach(n => {m += n;});
        return m / notas.Count;
      }
      return 0;
    }
  }

  public Notas(params float[] notas)
  {
    this.notas = notas.ToList();
  }

  public void AddNotas(params float[] notas)
  {
    this.notas.AddRange(notas.ToList());
  }

  public string GetNotas()
  {
    return $"Média das notas \"{string.Join(", ", notas)}\"\n é \"{media}\".";
  }
}
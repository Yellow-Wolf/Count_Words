/// <summary>
/// Подсчёт средней, медианы и ср.откл.
/// </summary>
/// <param name="times">Список со временем</param>
/// <returns>Среднее, медиана и среднеквадратическое отклонение</returns>
public Tuple<double, double, double> TimeCounting(List<int> times)
{
    double average = times.Sum();
    average /= times.Count;

    List<int> tmp = times;
    tmp.Sort();
    double median = tmp.Average();

    double summ = tmp.Select(x => (x - average) * (x - average)).Sum();
    double stddev = Math.Sqrt(summ / tmp.Count);

    return new Tuple<double, double, double>(average, median, stddev);
}
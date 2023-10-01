public class BadExam
{
    public double NewAverage(int[] marks)
    {
        // 1. 최고 점수 찾기
        int max = marks[0];
        foreach (int num in marks)
        {
            if (num > max)
                max = num;
        }

        // 2. 재조정
        double[] newScores = new double[marks.Length];
        for (int i = 0; i < marks.Length; i++)
        {
            newScores[i] = (double)marks[i] / max * 100;
        }

        // 3. 평균 계산
        double average = 0;
        foreach (double num in newScores)
        {
            average += num;
        }
        return average / marks.Length;
    }
}

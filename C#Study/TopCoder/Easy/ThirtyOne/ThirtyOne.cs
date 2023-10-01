public class ThirtyOne
{
    public int FindWinner(string[] hands)
    {
        string[][] cards1 = new string[hands.Length][];
        for (int i = 0; i < hands.Length; i++)
        {
            cards1[i] = hands[i].Split(' ');
        }

        // JQK는 10으로 변환
        string[][] cards = new string[hands.Length][];
        for (int i = 0; i < cards.Length; i++)
        {
            cards[i] = new string[3];
            for (int j = 0; j < 3; j++)
            {
                if (cards1[i][j] == "J" || cards1[i][j] == "Q" || cards1[i][j] == "K")
                {
                    cards[i][j] = "10";
                }
                else
                {
                    cards[i][j] = cards1[i][j];
                }
            }
        }

        // 점수를 담을 배열
        double[][] score = new double[hands.Length][];
        for (int i = 0; i < hands.Length; i++)
        {
            score[i] = new double[2];
            for (int j = 0; j < 3; j++)
            {
                if (cards[i][j] == "A")
                {
                    // A는 따로 체크해서 빼둠
                    score[i][1] += 1;
                }
                else
                {
                    score[i][0] += int.Parse(cards[i][j]);
                }
            }
        }

        // 3개가 같은 카드면 30.5점
        for (int i = 0; i < hands.Length; i++)
        {
            if (cards1[i][0] == cards1[i][1] && cards1[i][0] == cards1[i][2])
            {
                score[i][0] = 30.5;
                score[i][1] = 0;
            }
        }

        // A를 체크한 배열
        double[] finalScore = new double[hands.Length];
        for (int i = 0; i < hands.Length; i++)
        {
            if (score[i][1] == 0)
            {
                finalScore[i] = score[i][0];
            }
            else if (score[i][1] == 1)
            {
                if (score[i][0] + 11 > 31)
                {
                    finalScore[i] = score[i][0] + 1;
                }
                else
                {
                    finalScore[i] = score[i][0] + 11;
                }
            }
            else if (score[i][1] == 2)
            {
                if (score[i][0] + 22 > 31)
                {
                    finalScore[i] = score[i][0] + 12;
                }
                else
                {
                    finalScore[i] = score[i][0] + 22;
                }
            }
        }

        double max = 0;
        int answer = -1;
        for (int i = finalScore.Length - 1; i >= 0; i--)
        {
            if (finalScore[i] >= max)
            {
                max = finalScore[i];
                answer = i;
            }
        }

        return answer;
    }
}

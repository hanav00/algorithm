using System.Collections.Generic;

public class VeryInterestingMovie
{
    public int MaximumPupils(string[] seats)
    {
        Dictionary<int, int> canSeat = new Dictionary<int, int>();
        int index = 1;

        foreach (string seatRow in seats)
        {
            foreach (char seat in seatRow)
            {
                // "Y"로 시작하면 앉을 수 있는 자리에 넣기
                if (seat == 'Y')
                {
                    // index가 존재하면 count +1, 아니면 새로 생성
                    if (canSeat.ContainsKey(index))
                    {
                        canSeat[index] = canSeat[index] + 1;
                    }
                    else
                    {
                        canSeat[index] = 1;
                    }
                }
                if (seat == 'N')
                {
                    index++;
                }
            }
            index++;
        }

        // 가능한 자리에 앉을 수 있는 최대 학생 수 구하기
        int answer = 0;
        foreach (int values in canSeat.Values)
        {
            answer += (values + 1) / 2;
        }

        return answer;
    }
}

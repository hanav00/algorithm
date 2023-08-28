public class BadExam {
	public double newAverage(int[] marks) {
	    // 1. find max score
	    int max = marks[0];
	    for (int num : marks) {
	        if (num > max) max = num;
	    }
	    
	    // 2. readjust
	    double[] newScores = new double[marks.length];
	    for (int i = 0; i < marks.length; i++) {
	        newScores[i] = (double) marks[i] / max * 100;
	    }
	    
	    // 3. calculate average
	    double average = 0;
	    for (double num : newScores) {
	        average += num;
	    }
	    return average / marks.length;
	}
}

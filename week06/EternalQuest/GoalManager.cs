using System.IO;


public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private int _finishedGoals = 0;
    private string _filename;


    public void Start()
    {
        
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\n\nYou have {_score} points with {_finishedGoals} finished goals.\n");
    }

    public void ListGoalNames()
    {
        int i = 1;
        Console.WriteLine("The Goals are:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetNamesString()}");
            i++;
        }
    }

    public void ListGoalDetails()
    {
        Console.Clear();
        int i = 1;
        Console.WriteLine("The Goals are:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"\t{i}. {goal.GetDetailsString()}");
            i++;
        }

        if (_goals.Count == 0)
        {
            Console.WriteLine("\tNo goals yet.");
        }
        
    }

    public void CreateGoal()
    {
        Console.Clear();
        Goal goal = null;
        string points;

        Console.Write($"\nThe types of Goals are:\n\t1. Simple Goal\n\t2. Eternal Goal\n\t3. Checklist Goal\n\t4. Negative Goal\n\nWhich type of goal would you like to create? ");
        string input = (Console.ReadLine()).Trim().ToLower();
        Console.Write($"Enter name of goal: ");
        string name = (Console.ReadLine()).Trim().ToLower();
        Console.Write($"What is a short description of it? ");
        string description = (Console.ReadLine()).Trim().ToLower();
        

        if (input.Contains("1") || input.Contains("simple"))
        {
            Console.Write($"Number of points the goal is worth? ");
            points = (Console.ReadLine()).Trim().ToLower();
            goal = new SimpleGoal(name, description, points);
        }
        else if (input.Contains("2") || input.Contains("eternal"))
        {
            Console.Write($"Number of points the goal is worth? ");
            points = (Console.ReadLine()).Trim().ToLower();
            goal = new EternalGoal(name, description, points);
        }
        else if (input.Contains("3") || input.Contains("checklist"))
        {
            Console.Write($"Number of points the goal is worth? ");
            points = (Console.ReadLine()).Trim().ToLower();
            Console.Write($"How many times until goal bonus? ");
            string target = (Console.ReadLine()).Trim().ToLower();
            Console.Write($"What is the bonus amount? ");
            string bonus = (Console.ReadLine()).Trim().ToLower();
            goal = new ChecklistGoal(name, description, points, int.Parse(target), int.Parse(bonus));
        }
        else if (input.Contains("4") || input.Contains("negative"))
        {
            Console.Write($"How many points do we take away for doing this action? ");
            points = (Console.ReadLine()).Trim().ToLower();
            goal = new NegativeGoal(name, description, points);
        }
        else
        {
            Console.WriteLine("Please enter a goal option");
        }

        _goals.Add(goal);
            
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write($"\nWhich Goal did you accomplish?\n(type number please) ");
        string input = (Console.ReadLine()).Trim().ToLower();
        int inputInt = int.Parse(input);
        Goal goal = _goals[inputInt-1];
        goal.RecordEvent();
        Console.Clear();

        if (goal is NegativeGoal)
        {
            _score -= goal.GetScore();
            Console.Write($"\nDang, You have lost {goal.GetScore()} points.");
        }
        else
        {
            int points = goal.GetScore();
            _score += points;
            Console.Write($"\nCongratulations! You have earned {points} points!");
            _finishedGoals++;
        }
        
    }

    public void DeleteGoal()
    {
        ListGoalNames();
        Console.Write($"\nWhich Goal do you want to delete?\n(type number please) ");
        string input = (Console.ReadLine()).Trim().ToLower();
        int inputInt = int.Parse(input);
        _goals.RemoveAt(inputInt-1);
    }

    public void SaveGoals()
    {
        Console.WriteLine($"What is the filename? ");
        _filename = (Console.ReadLine()).Trim().ToLower();
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            outputFile.WriteLine($"{_score}|{_finishedGoals}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write($"\nWhat is the filename? ");
        _filename = (Console.ReadLine()).Trim().ToLower();
        string [] lines = System.IO.File.ReadAllLines(_filename);
        Goal goal = null;
        int completed = 0;
        int target = 0;
        int bonus = 0;
        int l = 0;
        _goals.Clear();

        foreach (string line in lines)
        {
            if (l == 0)
            {
                string [] parts = line.Split("|");
                _score = int.Parse(parts[0]);
                _finishedGoals = int.Parse(parts[1]);
            }
            else
            {
                string [] parts = line.Split("|");
                string name = parts[0];
                string description = parts[1];
                string points = parts[2];
                bool complete = bool.Parse(parts[3]);
                string type = parts[4];
                if (parts.Length > 7 && !string.IsNullOrWhiteSpace(parts[7]))
                {
                    completed = int.Parse(parts[5]);
                    target = int.Parse(parts[6]);
                    bonus = int.Parse(parts[7]);
                }
                

                if (type == "simple")
                {
                    goal = new SimpleGoal(name, description, points, complete);
                }
                else if (type == "checklist")
                {
                    goal = new ChecklistGoal(name, description, points, complete, completed, target, bonus);
                }
                else if (type == "eternal")
                {
                    goal = new EternalGoal(name, description, points, complete);
                }
                else if (type == "negative")
                {
                    goal = new NegativeGoal(name, description, points, complete);
                }

                _goals.Add(goal);
            }

            l++;
            

        }
    }


}
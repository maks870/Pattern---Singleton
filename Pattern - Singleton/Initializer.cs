using System;

public class Initializer
{
    private static Initializer instance = null;
    private bool isInitialized;

    private GameMenu menu;
    private Spawner enemySpawner;
    private Spawner playerSpawner;
    private Journal journal;
    private LevelLoader loader;

    private Initializer()
    {
        isInitialized = false;

        menu = new GameMenu();
        enemySpawner = new EnemySpawner();
        playerSpawner = new PlayerSpawner();
        journal = new Journal();
        loader = new LevelLoader();
    }

    public static Initializer getInstance()
    {
        if (instance == null)
            instance = new Initializer();

        return instance;
    }

    public void Initialize()
    {
        Console.WriteLine();
        Console.WriteLine("Try to initialize game");

        if (isInitialized)
        {
            Console.WriteLine("Game is already initialized");
            return;
        }

        Console.WriteLine("Initialize game");

        loader.LoadLevel();
        menu.CreateUI();
        journal.CreateQuests();
        playerSpawner.Spawn();
        enemySpawner.Spawn();

        isInitialized = true;
    }
}

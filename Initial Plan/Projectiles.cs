using System;

public class Projectile
{
    // Properties for position and velocity
    public float PositionX { get; set; }
    public float PositionY { get; set; }
    public float VelocityX { get; set; }
    public float VelocityY { get; set; }

    // Gravity acceleration constant
    private const float Gravity = -9.8f;
    
    // Ground level (assuming y = 0 is the ground)
    private const float GroundLevel = 0;

    // Constructor to initialize position and velocity
    public Projectile(float posX, float posY, float velX, float velY)
    {
        PositionX = posX;
        PositionY = posY;
        VelocityX = velX;
        VelocityY = velY;
    }

    // Update method to move the projectile
    public void Update(float deltaTime)
    {
        // Update velocity due to gravity (vertical only)
        VelocityY += Gravity * deltaTime;

        // Update position based on velocity
        PositionX += VelocityX * deltaTime;
        PositionY += VelocityY * deltaTime;

        // Check if projectile hits the ground
        if (PositionY <= GroundLevel)
        {
            PositionY = GroundLevel; // Snap to ground
            VelocityY = 0;           // Stop vertical movement
            Console.WriteLine("Projectile hit the ground!");
        }
    }

class Program
{
    static void Main()
    {
        // Create a projectile starting at (0, 10) with a velocity of (5, 10)
        Projectile projectile = new Projectile(0, 10, 5, 10);

        // Simulate the projectile motion for 5 seconds
        float time = 0f;
        float deltaTime = 0.1f;  // Simulation step (like a frame in a game)

        while (time < 5f)
        {
            projectile.Update(deltaTime);  // Move the projectile
            projectile.PrintPosition();    // Print its new position
            
            if (projectile.PositionY == 0)
                break; // Stop simulation if projectile hit the ground

            time += deltaTime;  // Increment time by deltaTime
        }
    }
}

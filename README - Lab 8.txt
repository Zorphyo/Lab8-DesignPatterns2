How the Design Patterns were Implemented
________________________________________

Object Pool: An ObjectPool class was created that holds a pool of Projectile prefabs. The bullets that the player ship shoots
come from this pool. When the bullets hit a wall past the camera, they reenter the pool.

Builder: Implemented an IBuilder interface and an EnemyBuilder class that builds objects of type Enemy. There are three different
parts of the enemy it can build - the size of the enemy, its point value, and its color. Right the EnemyBuilder builds enemies
with random values for all three of these parts as a demonstration. They can be set manually if desired.

Observer: Implemented an ISubject and IObserver interface, and made the Enemy class a subject and a ScoreManager class to act
as an Observer. Whenever an enemy is destroyed, it notifies the ScoreManager to update the score with whatever the point value
of the enemy is
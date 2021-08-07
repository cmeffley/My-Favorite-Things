# My-Favorite-Things
Practicing Classes, Properties, Fields and Methods
## Instructions
- Create at least four classes, each representing one of your favorite things. Something generic like a book, a car, or a beach.
- Give each of these things two or more properties (attributes) like Location, Name, Age, etc.
- Give each of these things two or more methods (behavior) like Open, Fly, etc.
    - At this point, your methods only need to Console.WriteLine sentences to represent the behavior.
- Inside your `Main` method, create at least two instances of each of your favorite things.
    - For instance, one of my favorite things are pets. My `Main` method might look like this.

        ```csharp
        var pickle = new Pet
        {
        	Name = "Bitsy",
        	Type = Pet.Cat, // <-- an enum called Pet
        	Age = 2
        };
        var data = new Pet
        {
        	Name = "Data",
        	Type = Pet.Dog, // <-- an enum called Pet
        	Age = 1
        };
        ```

- Access each of your instantiated favorite things and print the
attributes and behaviors to the console in any way you want. For
example:

    ```csharp
    Console.WriteLine(data.Speak("feed me")); // Data says "bark bark"
    ```

# Set Combinatorics Generator: 3-Element Variations

This C# console application generates all possible 3-element variations from a user-defined set. It includes specific logic to filter out combinations where all three elements are identical.

### Mathematical Context
For a set of $n$ elements, the total number of 3-element variations with repetitions is $n^3$. 
* The program explores the concept of **Variations with Repetitions**.
* **Filtering Logic:** The application identifies and excludes cases where all three elements are identical ($a = b = c$).

This project was developed as part of the curriculum at **Lviv Polytechnic National University**.

### Key Features
* **Dynamic Input:** Users can input any elements (letters, numbers) separated by spaces or commas.
* **Smart Validation:** Checks if the set is empty or has fewer than 3 elements.
* **Encoding Support:** Uses `UTF-8` to ensure correct display of Ukrainian characters in the console.

### Technical Stack
* **Language:** C# (.NET Core)
* **Key Concepts:** Nested loops, string parsing, conditional filtering.

open System

let do_funcs() =
  //Function
  let get_sum (x: int, y: int) : int = x + y
  printf "5 + 7 = %i" (get_sum(5,7))

  //Recursive function
  let rec factorial x =
    if x < 1 then 1
    else x * factorial (x - 1)

  printf "Factorial 4 : %i" (factorial 4)

  //Lamda expression
  let rand_list = [1;2;3]
  let rand_list2 = List.map (fun x -> x * 2) rand_list
  printfn "Double List : %A" rand_list2

  //Print list of even numbers times 2
  [5;6;7;8]
  |> List.filter (fun v -> (v % 2) = 0)
  |> List.map (fun x -> x * 2)
  |> printfn "Even Doubles : %A" 

  //Function chaining
  let mult_num x = x * 3
  let add_num y = y + 5
  //This is multiply then add
  let mult_add = mult_num >> add_num
  //This will add then multiply
  let add_mult = mult_num << add_num

  printfn "mult_add : %i" (mult_add 10)
  printfn "add_mult : %i" (add_mult 10)

  //Get data type of a variable
  let number = 2
  //Use A in print because we're pretty printng a union type.
  printfn "Type : %A" (number.GetType())
  //Cast number to float
  printfn "A Float : %.2f" (float number)
  //Cast float to number. All decimals are lost in conversion.
  printfn "A Int : %i" (int 3.14)

  //Absolute value
  printfn "abs 4.5 : %i" (abs -1)
  //Round up - use f in print because we're printing a float
  printfn "ceil 4.5 : %f" (ceil 4.5)
  //Round down
  printfn "floor 4.5 : %f" (floor 4.5)
  //Log function
  printfn "log 2.71828 : %f" (log 2.71818)
  //Log10 function
  printfn "log10 1000 : %f" (log10 1000.0)
  //Square root
  printfn "sqrt 25 : %f" (sqrt 25.0)

  //Escape characters
  // \n \\ \" \' %%
  //Standard string
  let str1 = "This is a random string"
  //Verbatum string
  let str2 = @"I ignore \backslashes\"
  //Tripple quoted strings
  let str3 = """ "I ignore double quotes and backslashes " """
  //Get length of string
  let str4 = str1 + " " + str2
  printfn "Length : %i" (String.length str4)
  //Print character of str by index
  printfn "2nd character in str1 : %c" str1.[1]
  //Print a substring
  printfn "Str1 substring : %s" (str1.[0..3])
  //Comma seperated string
  let upper_str = String.collect(fun c -> sprintf"%c, " c) "commas"
  printfn "Commas : %s" upper_str
  //Check if character meet a condition - in this case if any letters are uppercase
  printfn "Any upper : %b" (String.exists (fun c -> Char.IsUpper(c)) str1)
  //Check if all character meet condition - check if all characters in string are numbers
  printfn "Number : %b" (String.forall (fun c -> Char.IsDigit(c)) "1234")
  //Apply a function to each index in a string - create 10 characters as string
  let string1 = String.init 10 (fun i -> i.ToString())
  printfn "Numbers : %s" string1
  //Apply a function to each item in a string - print each character on a new line
  String.iter (fun c -> printfn "%c" c) "Print Me"

  //While loop
  let magic_num = "7"
  let mutable guess = ""

  while not (magic_num.Equals(guess)) do
    printf "Guess the number : "
    guess <- Console.ReadLine()

  printfn "You guessed the number"

  //For loop
  for i = 1 to 10 do
    printfn "%i" i

  for i = 10 downto 1 do
    printfn "%i" i

  for i in [1..10] do
    printfn "%i" i

  //Pipe values into list func
  [1..10] |> List.iter (printfn "Num : %i")
  //Sum a list
  


do_funcs()

Console.ReadKey() |> ignore

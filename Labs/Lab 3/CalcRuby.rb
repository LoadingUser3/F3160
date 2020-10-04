puts "Welcome to a basic Ruby Calculator!"

puts "Enter the first number"

#Initialize first number from user input

num1 = gets.to_i

puts "Enter the second number"

#Initialize second number from user input

num2 = gets.to_i

puts "Choose the operation" 

puts "+ for Addition"
    
puts "- for Subtraction"
    
puts "* for Multiplication"
    
puts "/ for Division"
##Initialize the operation from user input

operation = gets.chomp

#Switch case depends on the operation the user inputs. 

case operation
    

    when '+'
        result = num1 + num2
        print num1, operation, num2, "=", result, "\n"
    when '-'
        result = num1 - num2
        print num1, operation, num2, "=", result, "\n"
    when '*'
        result = num1 * num2
        print num1, operation, num2, "=", result, "\n"
    when '/'
        result = num1 / num2
        print num1, operation, num2, "=", result, "\n"
else
    
    #If the user inputs none of the above cases
    
   puts "Invalid Operation detected. Please try again"
end



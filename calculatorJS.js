const result_button = document.getElementById("result");
const clear = document.getElementById("clear");
const output = document.getElementById("output");

const operators = ["+", "-", "*", "/"];

/* Appends a value to the output string that will store the entire expression */
function number_input(num) {
  output.value = output.value + num.toString();
}

/*
 * Appends the operator to the expression string.
 * Does not append duplicate operators
*/
function operator_input(operator) {
  let expression = output.value;
  let op_present = false;

  for (let index = 0; index < operators.length; index++) {
    let op_pos = expression.indexOf(operators[index]);

    if (op_pos !== -1) {
      op_present = true;
    }
  }

  if (!op_present) {
    output.value += operator.toString();
  }
}


/*
 * Changes the style of the output box when the clear button is pressed
*/
clear.addEventListener("click", function () {
  output.value = "";
  output.style.borderColor = "#000000";
  output.style.color = "#000";
});


/*
 * Computes the result of the expression when the '=' button is pressed
*/
result_button.addEventListener("click", function () {
  let num1, num2;
  let op_pos = -1;
  let expression = output.value;
  let operator = "";
  let result = null;

  for (let index = 0; index < operators.length; index++) {
    op_pos = expression.indexOf(operators[index]);

    if (op_pos !== -1) {
      break;
    }
  }

  if (op_pos == -1) {
    output.value = "Invalid Expression";
    output.style.borderColor = "red";
    output.style.color = "red";
    return;
  }

  num1 = expression.substring(0, op_pos);
  num1 = parseFloat(num1);
  operator = expression.substring(op_pos, op_pos + 1);
  num2 = expression.substring(op_pos + 1);
  num2 = parseFloat(num2);

  if (isNaN(num2))
  {
    alert("where num 2?");
    return;
  }

  switch (operator) {
    case "+":
      result = num1 + num2;
      break;
    case "-":
      result = num1 - num2;
      break;
    case "*":
      result = num1 * num2;
      break;
    case "/":
      if (num2 === 0) {
        alert("YOU CANNOT DIVIDE BY ZERO");
        return;
      }
      result = num1 / num2;
      break;
  }

  output.value = result;

  return;
});

/* The function can be reduced to two lines using the eval function */
// result_button.addEventListener("click", function () {
//   output.value = eval(output.value);
// })
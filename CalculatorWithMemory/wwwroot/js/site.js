// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/expressionHub").build();

var expressionQueue = new Queue();

var memorySize = 10;

//Disable send button until connection is established
document.getElementById("submit").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
  var encodedMsg = message;
  var li = document.createElement("li");
  li.textContent = encodedMsg;
  updateExpressions(li);
});

connection.start().then(function () {
  document.getElementById("submit").disabled = false;
}).catch(function (err) {
  return console.error(err.toString());
});

document.getElementById("submit").addEventListener("click", function (event) {
  var user = document.getElementById("display").value;
  var msg = document.getElementById("display").value;
	var message = validateExpression(msg);
  connection.invoke("SendMessage", user, message).catch(function (err) {
    return console.error(err.toString());
  });
  event.preventDefault();
});

function validateExpression(expression) {
  var evaluated = eval(expression);
  var message = expression + " = " + evaluated;

  if (evaluated == undefined) {
    return "No Operation Performed";
  }
  else {
		document.getElementById("display").value = '';
		document.getElementById("display").placeholder = evaluated;
		return message;
	}
}

function updateExpressions(newElement) {
  // Keep variables in check.
  expressionQueue.enqueue(newElement);
	document.getElementById("messagesList").innerHTML = '';
	var newQueue = new Queue();

  if (expressionQueue.getLength() > memorySize) {
    var current = expressionQueue.dequeue();
  }

  // Variables to update the display.
	var counter = 0;
	var elements = [];

  // Update the messageslist view.
	while (expressionQueue.getLength() > 0) {
		var current = expressionQueue.dequeue();
		newQueue.enqueue(current);

		elements[counter] = current;
		counter++;
	}

  // Update the queue.
	expressionQueue = newQueue;

  // Print the previous results.
	for (var i = elements.length - 1; i >= 0; i--)
	{
		document.getElementById("messagesList").appendChild(elements[i]);
	}
}

document.getElementById("clear").addEventListener("click", function (event) {
  document.getElementById("display").value = '';
  document.getElementById("display").placeholder = '';
});

document.getElementById("seven").addEventListener("click", function (event) {
  document.getElementById("display").value += '7';
});

document.getElementById("eight").addEventListener("click", function (event) {
  document.getElementById("display").value += '8';
});

document.getElementById("nine").addEventListener("click", function (event) {
  document.getElementById("display").value += '9';
});

document.getElementById("four").addEventListener("click", function (event) {
  document.getElementById("display").value += '4';
});

document.getElementById("five").addEventListener("click", function (event) {
  document.getElementById("display").value += '5';
});

document.getElementById("six").addEventListener("click", function (event) {
  document.getElementById("display").value += '6';
});

document.getElementById("one").addEventListener("click", function (event) {
  document.getElementById("display").value += '1';
});

document.getElementById("two").addEventListener("click", function (event) {
  document.getElementById("display").value += '2';
});

document.getElementById("three").addEventListener("click", function (event) {
  document.getElementById("display").value += '3';
});

document.getElementById("divide").addEventListener("click", function (event) {
  document.getElementById("display").value += '/';
});

document.getElementById("mulitiply").addEventListener("click", function (event) {
  document.getElementById("display").value += '*';
});

document.getElementById("minus").addEventListener("click", function (event) {
  document.getElementById("display").value += '-';
});

document.getElementById("plus").addEventListener("click", function (event) {
  document.getElementById("display").value += '+';
});

document.getElementById("zero").addEventListener("click", function (event) {
  document.getElementById("display").value += '0';
});

document.getElementById("dot").addEventListener("click", function (event) {
  document.getElementById("display").value += '.';
});


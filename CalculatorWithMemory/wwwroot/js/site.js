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
  var msg = message;
  var evaluated = eval(message);
  var encodedMsg = msg + " = " +  evaluated;
  var li = document.createElement("li");
  li.textContent = encodedMsg;
  document.getElementById("messagesList").appendChild(li);
  updateExpressions(li);
  document.getElementById("display").value = '';
  document.getElementById("display").placeholder = evaluated;
});

connection.start().then(function () {
  document.getElementById("submit").disabled = false;
}).catch(function (err) {
  return console.error(err.toString());
});

document.getElementById("submit").addEventListener("click", function (event) {
  var user = document.getElementById("display").value;
  var message = document.getElementById("display").value;
  connection.invoke("SendMessage", user, message).catch(function (err) {
    return console.error(err.toString());
  });
  event.preventDefault();
});

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

"use strict";

var connection = new signalR.HubConnectionBuilder()
    .withUrl("/global")
    .configureLogging(signalR.LogLevel.Information)
    .build();

connection.start().then(
    () => console.log("connected")
).catch(
    err => console.error(err)
);  

connection.on("BroadcastMessage", function (user, message) {
    console.log('received');
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var encodedMsg = user + " says " + msg;
    var li = document.createElement("li");
    li.textContent = encodedMsg;
    alert(encodedMsg);
});
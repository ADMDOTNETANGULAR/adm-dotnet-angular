// Load tasks from localStorage
window.onload = function () {
    loadTasks();
};

function addTask() {
    const input = document.getElementById("taskInput");
    const taskText = input.value.trim();

    if (taskText === "") return;

    const task = {
        text: taskText,
        done: false
    };

    const tasks = getTasks();
    tasks.push(task);
    localStorage.setItem("tasks", JSON.stringify(tasks));

    input.value = "";
    renderTasks();
}

function getTasks() {
    return JSON.parse(localStorage.getItem("tasks")) || [];
}

function loadTasks() {
    renderTasks();
}

function toggleDone(index) {
    const tasks = getTasks();
    tasks[index].done = !tasks[index].done;
    localStorage.setItem("tasks", JSON.stringify(tasks));
    renderTasks();
}

function deleteTask(index) {
    const tasks = getTasks();
    tasks.splice(index, 1);
    localStorage.setItem("tasks", JSON.stringify(tasks));
    renderTasks();
}

function renderTasks() {
    const taskList = document.getElementById("taskList");
    taskList.innerHTML = "";

    const tasks = getTasks();
    tasks.forEach((task, index) => {
        const li = document.createElement("li");
        li.className = task.done ? "done" : "";
        li.innerHTML = `
      <span onclick="toggleDone(index)">${task.text}</span>
      <span class="delete-btn" onclick="deleteTask(${index})">✖</span>
    `;
        taskList.appendChild(li);
    });
}

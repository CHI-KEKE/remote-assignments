const CalcBtn = document.querySelector("#calBtn");
function calculateSum() {
    const number = document.querySelector("#numberInput").value;

    fetch(`https://localhost:7108/FirstWebAPI?number=${number}`)
        .then(response => response.json())
        .then(result => {
            showResult(result);
        })
        .catch(error => {
            console.error("Error:", error);
        });
}

function showResult(result) {
    var resultContainer = document.getElementById("resultContainer");
    resultContainer.textContent = "Result: " + result;
    resultContainer.classList.remove("hide");
    resultContainer.classList.add("show");
}

function hideResult() {
    var resultContainer = document.getElementById("resultContainer");
    resultContainer.classList.remove("show");
    resultContainer.classList.add("hide");
}

CalcBtn.addEventListener("click", calculateSum)

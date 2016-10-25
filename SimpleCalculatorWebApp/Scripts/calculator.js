function loadClickedNumber(num) {

    if (document.getElementById("textBoxActive").value == "TB1")
        document.getElementById("Text1").value += num.trim();
    else if (document.getElementById("textBoxActive").value == "TB2")
        document.getElementById("Text2").value += num.trim();

}

function setActiveTextBox(operand) {

    if (operand == "Op1")
        document.getElementById("textBoxActive").value = "TB1"
    else if (operand == "Op2")
        document.getElementById("textBoxActive").value = "TB2"

}

function clearAllFields() {

    document.getElementById("Text1").value = null;
    document.getElementById("Text2").value = null;

    document.getElementById("Add").checked = null; 
    document.getElementById("Sub").checked = null;
    document.getElementById("Mlt").checked = null;
    document.getElementById("Div").checked = null;

}
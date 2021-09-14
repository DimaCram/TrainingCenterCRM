let inpFile = document.getElementById("fileElem");

let dropArea = document.getElementById("drop-area")

    ;['dragenter', 'dragover', 'dragleave', 'drop'].forEach(eventName => {
        dropArea.addEventListener(eventName, preventDefaults, false)
        document.body.addEventListener(eventName, preventDefaults, false)
    })

    ;['dragenter', 'dragover'].forEach(eventName => {
        dropArea.addEventListener(eventName, highlight, false)
    })

    ;['dragleave', 'drop'].forEach(eventName => {
        dropArea.addEventListener(eventName, unhighlight, false)
    })

dropArea.addEventListener('drop', handleDrop, false)

function preventDefaults(e) {
    e.preventDefault()
    e.stopPropagation()
}

function highlight(e) {
    dropArea.classList.add('highlight')
}

function unhighlight(e) {
    dropArea.classList.remove('highlight')
}

function handleDrop(e) {
    var dt = e.dataTransfer
    createInputFile(dt.files);
}

$("#fileElem").change(function () {
    let files = inpFile.files;
    createInputFile(files);
});


function createInputFile(files) {
    if (files.length >= 1) {
        if (validateFile(files[0])) {
            let fileReader = new FileReader();
            fileReader.onload = () => {
                $('#img-icon').attr('src', fileReader.result);
                const dT = new DataTransfer();
                dT.items.add(files[0]);
                let newFile = document.getElementById(`fileElem`);
                newFile.files = dT.files;
            };
            fileReader.readAsDataURL(files[0]);
        }
    }
}
function validateFile(file) {
    const allowedExtensions = ['jpg', 'jpeg', 'png'],
        sizeLimit = 5_000_000;

    const fileExtension = file.name.split(".").pop();

    if (!allowedExtensions.includes(fileExtension)) {
        showToast("Error message", `"${file.name}" type not allowed. Allowed types ${allowedExtensions.join(", ")}.`, "error");
        return false;
    } else if (file.size > sizeLimit) {
        showToast("Error message", `"${file.name}" size too large. Max size ${Math.trunc(sizeLimit / 1000000)} MB`, "error");
        return false;
    }
    return true;
}


function setImageToInput() {
    inpFile.getAttribute("")
}
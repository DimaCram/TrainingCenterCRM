checkSelectedFiles();

let inpFile = document.getElementById("fileElem");
let allfiles;
let fileNumber = 0;

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
    for (let i = 0; i < files.length; i++) {
        if (validateFile(files[i])) {
            let inputElem = $(`<input id='file-${fileNumber}' class="d-none"/>`).attr('type', 'file').attr('name', 'files');

            $(`<li class="list-group-item list-item">
                ${files[i].name}
                <button class="deleteFile btn btn-danger"><i class="fas fa-times"></i></button>
            </li>`).appendTo(".files-group").append(inputElem);

            const dT = new DataTransfer();
            dT.items.add(files[i]);
            let newFile = document.getElementById(`file-${fileNumber}`);
            newFile.files = dT.files;
            fileNumber++;
        }
    }
    checkSelectedFiles();
}
function validateFile(file) {
    const allowedExtensions = ['doc', 'docx', 'ppt', 'pptx', 'pdf'],
          sizeLimit = 5_000_000; 

    const fileExtension = file.name.split(".").pop();

    if (!allowedExtensions.includes(fileExtension)) {
        alert(`"${file.name}" type not allowed. Allowed types ${allowedExtensions.join(", ")}.`);
        return false;
    } else if (file.size > sizeLimit) {
        alert(`"${file.name}" size too large. Max size ${sizeLimit}`);
        return false;
    }
    return true;
}
function checkSelectedFiles() {
    if ($("input[name='files']").length == 0) {
        $("#submit").prop("disabled", true);
    } else {
        $("#submit").prop("disabled", false);
    }
    
}

$('body').on('click', '.deleteFile', function () {
    $(this).parent().remove();
    checkSelectedFiles();
});
let toastIndex = 0;

function showToast(header, body, toastType) {
    var toast = getToast(`toast-${toastIndex}`, header, body, toastType);
    $(".toast-container").append(toast);

    var bsAlert = new bootstrap.Toast(`#toast-${toastIndex}`);
    bsAlert.show();
    toastIndex++;
}

function getToast(id, header, body, toastType) {
    let toastIcon = "";
    let toastColor = "";

    switch (toastType) {
        case 'error':
            toastIcon = '<i class="fas fa-exclamation-triangle"></i>';
            toastColor = "text-danger";
            break;
        case 'warning':
            toastIcon = '<i class="fas fa-exclamation-triangle"></i>';
            toastColor = "text-warning";
            break;
        case 'info':
            toastIcon = '<i class="fas fa-info"></i>';
            toastColor = "text-info";
            break;
    }

    const toast = `
      <div id="${id}" class="toast hide" role="alert" aria-live="assertive" aria-atomic="true" data-bs-autohide="true" data-bs-delay="5000">
        <div class="toast-header ${toastColor}">
          <div class="me-2">${toastIcon}</div>
          <strong class="me-auto">${header}</strong>
          <button type="button" class="btn-close" data-bs-dismiss="toast" aria-label="Close"></button>
        </div>
        <div class="toast-body">
          ${body}
        </div>
      </div>`;
    return toast;
}
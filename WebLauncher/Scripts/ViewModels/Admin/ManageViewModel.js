var manageViewModel = function (data) {
    var self = this;
    
    self.createableYears = ko.observableArray(data.YearsWithNoCreatedSeasons);
    self.editableYears = ko.observableArray(data.EditableSeasons);

    self.showViewForm = ko.observable(false);
    self.showEditForm = ko.observable(false);
    self.showAddForm = ko.observable(false);

    self.displayViewButton = function () {
        var currentDisplayValue = self.showViewForm();
        self.showViewForm(!currentDisplayValue);
    }

    self.displayEditButton = function () {
        var currentDisplayValue = self.showEditForm();
        self.showEditForm(!currentDisplayValue);
    }

    self.displayAddButton = function () {
        var currentDisplayValue = self.showAddForm();
        self.showAddForm(!currentDisplayValue);
    }

    self.addYear = function () {
        debugger;
    }

    self.editYear = function () {
        debugger;
    }

    self.viewYear = function () {
        debugger;
    }
};
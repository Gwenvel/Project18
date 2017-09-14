class ArtistController {
    constructor($artistService) {
        this.artistService = $artistService;
        this.artists = this.artistService.getArtists();
        this.artistDetail = null;
        this.resetMessages();
    }

    resetMessages() {
        this.showSuccess = false;
        this.showError = false;
        this.serverMessage = "";
    }
    getArtist(id) {
        this.resetMessages();
        this.artistDetail = this.artistService.getArtist(id);
    }
}
<style scoped lang="scss">
  .card {
    max-width: 600px;
  }

  .wrapper {
    display: flex;
    justify-content: space-around;
  }
</style>

<template>
  <div class="content">
    <Headline :level=2 styling="page-title">Datenschutzerklärung</Headline>
    <div class="wrapper">
      <Card class="card">
        <Paragraph>
          Verantwortlicher für die Erhebung, Verarbeitung und Nutzung Ihrer personenbezogenen Daten
          im
          Sinne von Art. 4 Nr. 7 DSGVO ist
        </Paragraph>
        <Paragraph>
          Ehrengarde der Stadt Neuwied e. V. <br/>
          Hochstraße 128 <br/>
          56566 Neuwied <br/>
        </Paragraph>

        <Headline :level=3 styling="card-title">
          Betroffenenrechte: Rechte auf Auskunft, Berichtigung, Sperre, Löschung und Widerspruch
        </Headline>
        <Paragraph>
          Sie haben das Recht, auf Antrag unentgeltlich eine Auskunft über die bei uns gespeicherten
          personenbezogenen Daten anzufordern und/oder eine Berichtigung, Sperrung oder Löschung zu
          verlangen. Eine Sperrung oder Löschung kann nicht erfolgen, wenn gesetzliche Regelungen
          dem entgegenstehen.
        </Paragraph>
        <Paragraph>
          Bitte kontaktieren Sie unseren Datenschutzbeauftragten unter
          <a href="mailto:datenschutz@ehrengarde-neuwied.de">datenschutz@ehrengarde-neuwied.de</a>.
        </Paragraph>

        <Headline :level=3 styling="card-title">
          Datenvermeidung und Datensparsamkeit
        </Headline>
        <Paragraph>
          Wir speichern gemäß den Grundsätzen der Datenvermeidung und Datensparsamkeit
          personenbezogene Daten nur so lange, wie dies erforderlich ist oder vom Gesetzgeber
          vorgeschrieben wird.
        </Paragraph>

        <Headline :level=3 styling="card-title">
          Erfassung allgemeiner Informationen
        </Headline>
        <Paragraph>
          Informationen zu einem Zugriff auf unseren Internetauftritt werden grundsätzlich nicht
          automatisiert (in Form von Logfiles) erfasst. Für administrative Zwecke kann eine
          kurzfristige Erstellung von Logfiles notwendig werden. Die Logfiles werden in diesem
          Fall
          anschließend gelöscht. Die Logfiles sind von allgemeiner Natur und erlauben keine
          Rückschlüsse auf Ihre Person.
        </Paragraph>
        <Paragraph>
          Sofern Logfiles erstellt werden, können unter anderem folgende Datenarten erfasst
          werden:
          IP-Adresse und Datum.
        </Paragraph>

        <Headline :level=3 styling="card-title">
          Typekit
        </Headline>
        <Paragraph>
          Um den Besuch unserer Website attraktiv zu gestalten benutzen wir externe Schriften von
          Adobe Typekit. Diese werden beim Besuch der Seite von Servern der Adobe Systems Inc., San
          Jose, Kalifornien, USA abgerufen. Adobe setzt dabei keine Cookies zur Erbringung des
          Dienstes. Nach unseren Informationen wird jedoch die IP-Adresse des Endgerätes des Nutzers
          an Adobe übertragen und gespeichert. Weitere Informationen zum Datenschutz bei Adobe
          Typekit finden Sie in der Datenschutzerklärung von Adobe:
          <a href="https://www.adobe.com/de/privacy/policies/adobe-fonts.html">
            https://www.adobe.com/privacy/policies/typekit.html
          </a>
        </Paragraph>

        <Headline :level=3 styling="card-title">OpenStreetMap</Headline>
        <Paragraph>
          Wir binden auf unserer Internetseite die Landkarten des Dienstes "OpenStreetMap" ein
          (<a href="https://www.openstreetmap.de">https://www.openstreetmap.de</a>), die auf
          Grundlage der Open Data Commons Open Database
          Lizenz (ODbL) durch die OpenStreetMap Foundation (OSMF) angeboten werden. Die
          Datenschutzerklärung der OpenStreetMap Foundation finden Sie hier:
          <a href="https://wiki.openstreetmap.org/wiki/Privacy_Policy">https://wiki.openstreetmap.org/wiki/Privacy_Policy</a>.
        </Paragraph>
        <Paragraph>
          Nach unserer Kenntnis werden die Daten der Nutzer durch OpenStreetMap ausschließlich zu
          Zwecken der Darstellung der Kartenfunktionen und Zwischenspeicherung der gewählten
          Einstellungen verwendet. Es besteht die Möglichkeit, dass beim Aufruf der Landkarten die
          IP-Adresse sowie die Standortdaten des Nutzers an OpenStreetMap übermittelt, jedoch
          nicht
          ohne Einwilligung des Nutzers erhoben werden. Im Regelfall erfolgt diese Einwilligung im
          Rahmen der Einstellungen im Mobilgerät des Nutzers.
        </Paragraph>
        <Paragraph>
          Die erhobenen Daten können in den USA verarbeitet werden. Weitere Informationen können
          Sie der Datenschutzerklärung von OpenStreetMap entnehmen:
          <a href="https://wiki.openstreetmap.org/wiki/Privacy_Policy">https://wiki.openstreetmap.org/wiki/Privacy_Policy</a>.
        </Paragraph>

        <Headline :level=3 styling="card-title">Carto</Headline>
        <Paragraph>
          Wir binden auf unsere Website die Kartendaten des Dienstes Canto <a
          href="https://carto.com/">Carto</a> ein. Es besteht die Möglichkeit, dass beim Aufruf der
          Landkarten die IP-Adresse sowie die Standortdaten des Nutzers an Carto
          übermittelt werden. Die erhobenen Daten können in den USA verabeitet
          werden. weiter Informationen könne Sie der Datenschutzerklärung von Carto entnehem:
          <a href="https://carto.com/privacy/">https://carto.com/privacy/</a>
        </Paragraph>
      </Card>
    </div>
  </div>

</template>

<script>
  import Card from '../components/atoms/Card.vue';
  import Headline from '../components/atoms/Headline.vue';
  import Paragraph from '../components/atoms/Paragraph.vue';

  export default {
    name: 'Datenschutz',
    components: {Paragraph, Headline, Card},
  };
</script>

<template>
  <div class="content">
    <Headline :level=2 styling="page-title">Eine saubere Sache…</Headline>
    <Headline :level=2 styling="page-title">…das Spülmobil der Ehrengarde</Headline>
    <TopicHeader :src="spuelmobil" title="Spülmobil" />
    <Paragraph>
      Während der Markttage im Jahr 2022 entstand die Idee, den Plastikmüll bei der Ausgabe von
      Essen zu reduzieren beziehungsweise auf Plastik-Einweggeschirr gänzlich zu verzichten.
      Also war unser Ziel an den Markttagen 2023 nachhaltiges Mehrweggeschirr zu nutzen gesetzt.
      Dieses Geschirr muss jedoch auch vor Ort gespült werden. So musste nicht nur Geschirr,
      sondern ein Spülmobil her.
    </Paragraph>
    <Paragraph>
      Wir haben die Wintermonate genutzt, um die Bedürfnisse zusammen zu stellen und ein
      ausgereiftes Konzept zu erstellen. Wir starteten gemeinsam mit der VR Bank RheinAhrEifel
      eG unter dem Motto „Viele schaffen mehr“ eine Crowdfunding-Aktion. Zeitgleich suchten wir
      nach einem passenden „fahrbaren Untersatz“ und erkundeten den Markt nach Geschirr und Spülmaschinen.
    </Paragraph>
    <Paragraph>
      Um unsere Bedürfnisse zu erfüllen, haben wir den Bau des Spülmobiles mit einer kleinen Mannschaft
      selbst durchgeführt und aus einem Anhänger ein Spülmobil mit zwei Spülmaschinen, zwei Waschbecken
      mit Handbrause und Warmwasserboiler gebaut, welches noch genügend Platz hat um ausreichend Geschirr zu
      transportieren.
    </Paragraph>
    <Headline :level=3 styling="page-title">Beladung</Headline>
    <ul>
      <li>
        400 Teller flach Ø 25,5&nbsp;cm
      </li>
      <li>
        400 Teller tief Ø 23&nbsp;cm
      </li>
      <li>
        400 Teller klein Ø 19&nbsp;cm
      </li>
      <li>
        400 Tassen
      </li>
      <li>
        400 Bestecksätze (Messer, Gabel, Löffel)
      </li>
      <li>
        400 Steakmesser
      </li>
      <li>
        400 Kaffeelöffel und Kuchengabeln
      </li>
      <li>
        div. Spülkörbe
      </li>
      <li>
        Zuwasserschlauch nach DVGW
      </li>
      <li>
        Abwasserschlauch
      </li>
      <li>
        Zuleitung 32A/400V, 16A/400V, 230V CEE
      </li>
    </ul>
    <Headline :level=3 styling="page-title">Eckdaten</Headline>
    <ul>
      <li>
        Tandem-Kofferanhänger mit seitlicher Klappe
      </li>
      <li>
        Zulässiges Gesamtgewicht: 2.000&nbsp;kg
      </li>
      <li>
        Stellmaß (geöffnet): 350 x 550&nbsp;cm zzgl. Arbeitstische
      </li>
      <li>
        2 Industriespülmaschinen der Firma Jörg Dupp GmbH mit Spülprogrammen ab 60&nbsp;Sek.
      </li>
      <li>
        Wasseranschluss nach DVGW
      </li>
      <li>
        Stromanschluss 32A/400V (oder 16A/400V und 16A/230V)
      </li>
      <li>
        Gesamtanschlusswert ca. 12&nbsp;kW
      </li>
    </ul>
    <Paragraph>
      Weitere Infos unter <a href="mailto:spuelmobil@ehrengarde-neuwied.de">spuelmobil@ehrengarde-neuwied.de</a>
    </Paragraph>
  </div>
</template>

<script>
import spuelmobil from '../assets/photos/spuelmobile/spuelmobil_1.jpg';
import Paragraph from '../components/atoms/Paragraph.vue';
import Headline from '../components/atoms/Headline.vue';
import TopicHeader from '../components/molecules/TopicHeader.vue';

export default {
  name: 'home',
  components: {
    Headline,
    Paragraph,
    TopicHeader,
  },
  data() {
    return {
      spuelmobil,
    };
  },
};
</script>
